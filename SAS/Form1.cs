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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Links();
        }
        Account Acc = new Account();
        Bazar Baz = new Bazar();
        static public TelegramClient client = new TelegramClient(2172541, "d5a5a132ad869a3b238d7b17777e3007");
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        async private void ListAccs(int rows, int button_number, string text)
        {
            Account.rows = rows;
            await client.ConnectAsync();
            await Baz.RequestFile(client, button_number);
            this.objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = text;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListAccs(33, 0, "PUBG");
        }
        private void gTAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAccs(33, 2, "GTA V");
        }
        private void rUSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAccs(33, 3, "RUST");
        }
        private void rOCKETLEAGUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAccs(33, 4, "ROCKET LEAGUE");
        }
        private void lIMITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAccs(34, 5, "LIMIT");
        }
        private void nOLIMITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAccs(34, 6, "NOLIMIT");
        }
        private void pRIMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bazar.IsCSGO = true;
            ListAccs(33, 0, "PRIME");
        }
       private void iNV50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bazar.IsCSGO = true;
            ListAccs(33, 1, "INV>50");
        }
        private void vACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bazar.IsCSGO = true;
            ListAccs(33, 2, "VAC");
        }
    }
}
