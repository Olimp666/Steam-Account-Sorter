using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Bazar b = new Bazar();
        bool q = false;
        TelegramClient client = new TelegramClient(2172541, "d5a5a132ad869a3b238d7b17777e3007");
        string hash,number;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        async private void button1_Click(object sender, EventArgs e)
        {
            if (!q)
            {
                number = textBox1.Text;
                q = true;
                await client.ConnectAsync();
                try
                {
                    hash = await client.SendCodeRequestAsync(number);
                    textBox1.Text = "Code";
                    button1.Text = "Authorize";
                }
                catch(System.InvalidOperationException)
                {
                    q = false;
                    System.Windows.Forms.MessageBox.Show("Invalid phone number", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            else
            {
                var code = textBox1.Text;
                var user = await client.MakeAuthAsync(number, hash, code);
                client.Session.TLUser = user;
                Form1.client = client;
                this.Close();
            }
        }
    }
}
