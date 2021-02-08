using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using TLSharp.Core;
using TeleSharp.TL.Account;
using TeleSharp.TL.Auth;
using TeleSharp.TL.Contacts;
using TeleSharp.TL.Help;
using TeleSharp.TL.Messages;
using TeleSharp.TL.Upload;
using TLSharp.Core.Auth;
using TLSharp.Core.Exceptions;
using TLSharp.Core.MTProto.Crypto;
using TLSharp.Core.Network;
using TLSharp.Core.Network.Exceptions;
using TLSharp.Core.Utils;
using System.IO;

namespace SAS
{
    class Bazar
    {
        public Bazar()
        {

        }
        static public bool InStock=true;
        static public bool IsCSGO = false;
        int CSNumber;
        static int bot_id = 904286953;
        static long access_hash;
        static TLInputPeerUser peer = new TLInputPeerUser()
        {
            UserId = bot_id,
            AccessHash = access_hash
        };
        public TLMessage Lastmessage
        {
            get { return lastmessage; }
            set { lastmessage = value; }
        }
        static private TLMessage lastmessage;
        public TelegramClient client = new TelegramClient(2172541, "d5a5a132ad869a3b238d7b17777e3007");
        async public void Connect()
        {
            await client.ConnectAsync();
        }
        async static public Task GetAccessHash(TelegramClient client)
        {
            var request = await client.SendRequestAsync<TLResolvedPeer>(new TLRequestResolveUsername() { Username = "steambuy_bot" });
            TLUser info = (TLUser)request.Users.AsEnumerable().ElementAt(0);
            peer.AccessHash = (long)info.AccessHash;
        }
        static public int GetMessageId(TLMessagesSlice dialogs)
        {
            var all_messages = dialogs.Messages.AsEnumerable().ToList();
            lastmessage = all_messages.Where(c => c.GetType() == typeof(TLMessage)).Cast<TLMessage>().ElementAt(0);
            int msg_id = lastmessage.Id;
            return msg_id;
        }
        static public byte[][] GetData()
        {
            TLReplyInlineMarkup a = (TLReplyInlineMarkup)lastmessage.ReplyMarkup;
            var b = a.Rows.AsEnumerable().ToList();
            byte[][] data = new byte[b.Count][];
            for (int i = 0; i < b.Count; i++)
            {
                data[i] = GetDataFromButton(b[i]);
            }
            return data;
        }
        static public byte[] GetDataFromButton(TLKeyboardButtonRow button)
        {
            var a = button.Buttons.AsEnumerable().ToList();
            TLKeyboardButtonCallback b = (TLKeyboardButtonCallback)a[0];
            byte[] data = b.Data;
            return data;
        }
        public async Task RequestFile(TelegramClient client, int button_number)
        {
            await GetAccessHash(client);
            await Task.WhenAny(client.SendMessageAsync(peer, "Menu"));
            var po = GetHistory(client);
            int msg_id=GetMessageId(po);

            if(IsCSGO)
            {
                CSNumber = button_number;
                button_number = 1;
            }
            byte[][] buttons = GetData();
            byte[] data = buttons[button_number];

            var request = new TLRequestGetBotCallbackAnswer()
            {
                Peer = peer,
                Data = data,
                MsgId = msg_id
            };
            client.SendRequestAsync<Object>(request).Wait();
            if (IsCSGO)
            {
                IsCSGO = false;
                po = GetHistory(client);
                msg_id =GetMessageId(po);

                buttons = GetData();
                data = buttons[CSNumber];

                request = new TLRequestGetBotCallbackAnswer()
                {
                    Peer = peer,
                    Data = data,
                    MsgId = msg_id
                };
                client.SendRequestAsync<Object>(request).Wait();
            }

            if (!AccInStock(GetHistory(client)))
            {
                InStock = false;
                System.Windows.Forms.MessageBox.Show("Temporary unavailable\nTry again later","Not in stock",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                goto End;
            }
            while(!IsMedia(po))
            {
                po = GetHistory(client);
            }
            DownloadFile(po, client);
        End:
            ;
        }
        public bool AccInStock(TLMessagesSlice messages)
        {
            TLMessage message = (TLMessage)messages.Messages.AsEnumerable().ElementAt(0);
            if (message.Message == "🕹 В этой категории пока нету аккаунтов\n🚁 Бот напишет вам как пополнит аккаунты")
                return false;
            else
                return true;
        }
        public TLMessagesSlice GetHistory(TelegramClient client)
        {
            return (TLMessagesSlice)client.GetHistoryAsync(peer).Result;
        }
        public bool IsMedia(TLMessagesSlice messages)
        {
            TLMessage message = (TLMessage)messages.Messages.AsEnumerable().ElementAt(0);
            TLMessageMediaDocument mediadata = (TLMessageMediaDocument)message.Media;
            if (mediadata == null)
                return false;
            else
                return true;
        }
        public TLDocument GetFileData(TLMessagesSlice messages)
        {
            TLMessage message = (TLMessage)messages.Messages.AsEnumerable().ElementAt(0);
            TLMessageMediaDocument mediadata = (TLMessageMediaDocument)message.Media;
            TLDocument filedata = (TLDocument)mediadata.Document;
            return filedata;
        }
        public string GetFileName(TLDocument filedata)
        {
            var attributes = filedata.Attributes;
            TLDocumentAttributeFilename file_name = (TLDocumentAttributeFilename)attributes.AsEnumerable().ElementAt(0);
            return file_name.FileName;
        }
        public void DownloadFile(TLMessagesSlice messages,TelegramClient client)
        {
            TLDocument document = GetFileData(messages);
            string file_name = GetFileName(document);


            var loc = new TLInputDocumentFileLocation()
            {
                AccessHash = document.AccessHash,
                Id = document.Id,
                Version = document.Version
            };

            var mb = 1048576;
            var upperLimit = (int)Math.Pow(2, Math.Ceiling(Math.Log(document.Size, 2))) * 4;
            var limit = Math.Min(mb, upperLimit);

            var currentOffset = 0;
            File.WriteAllText(file_name, "");
            using (var fs = File.OpenWrite(file_name))
            {
                while (currentOffset < document.Size)
                {
                    var file = client.GetFile(loc, limit, currentOffset).ConfigureAwait(false).GetAwaiter().GetResult();
                    fs.Write(file.Bytes, currentOffset, file.Bytes.Length);
                    currentOffset += file.Bytes.Length;
                }

                fs.Close();
            }
        }
    }
}
