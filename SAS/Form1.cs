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
        Bazar a = new Bazar();
        static public TelegramClient client = new TelegramClient(2172541, "d5a5a132ad869a3b238d7b17777e3007");
        private void Form1_Load(object sender, EventArgs e)
        {
            client.ConnectAsync();
        }


        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        async private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Account.rows = 33;
            await a.RequestFile(client, 0);
            this.objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "PUBG";
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cSGOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        async private void gTAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.rows = 33;
            await a.RequestFile(client, 2);
            this.objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "GTA V";
        }

        async private void rUSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.rows = 33;
            await a.RequestFile(client, 3);
            this.objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "RUST";
        }

        async private void rOCKETLEAGUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.rows = 33;
            await a.RequestFile(client, 4);
            this.objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "ROCKET LEAGUE";
        }

        async private void lIMITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.rows = 34;
            await a.RequestFile(client, 5);
            this.objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "LIMIT";
        }



        async private void nOLIMITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.rows = 34;
            await a.RequestFile(client, 6);
            objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "NOLIMIT";
        }

        async private void pRIMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.rows = 33;
            Bazar.IsCSGO = true;
            await a.RequestFile(client, 0);
            objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "PRIME";
        }

        async private void iNV50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.rows = 33;
            Bazar.IsCSGO = true;
            await a.RequestFile(client, 1);
            objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "INV>50";
        }

        async private void vACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.rows = 33;
            Bazar.IsCSGO = true;
            await a.RequestFile(client, 2);
            objectListView1.SetObjects(Acc.InitializeAccs());
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem1.Text = "VAC";
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
