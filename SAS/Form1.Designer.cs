
namespace SAS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void Links()
        {
            this.objectListView1.IsHyperlink += (sender, args) => {

                args.IsHyperlink = true;
                args.Url = "https://steamcommunity.com/profiles/" + args.Text;
            };
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRIMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNV50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gTAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOCKETLEAGUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIMITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOLIMITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.AllColumns.Add(this.olvColumn4);
            this.objectListView1.AllColumns.Add(this.olvColumn5);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.GridLines = true;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(0, 24);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(438, 974);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseHyperlinks = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ID";
            this.olvColumn1.Groupable = false;
            this.olvColumn1.Hyperlink = true;
            this.olvColumn1.Text = "ID";
            this.olvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.Width = 115;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Inv";
            this.olvColumn2.Groupable = false;
            this.olvColumn2.Text = "Inventory($)";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.Width = 85;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Price";
            this.olvColumn3.Groupable = false;
            this.olvColumn3.Text = "Price (RUB)";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.Width = 90;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Balance";
            this.olvColumn4.Groupable = false;
            this.olvColumn4.Text = "Balance";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn4.Width = 70;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Currency";
            this.olvColumn5.Text = "Currency";
            this.olvColumn5.Width = 75;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.aToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.файлToolStripMenuItem.Text = "Sorter";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Authorize";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.cSGOToolStripMenuItem,
            this.gTAVToolStripMenuItem,
            this.rUSTToolStripMenuItem,
            this.rOCKETLEAGUEToolStripMenuItem,
            this.lIMITToolStripMenuItem,
            this.nOLIMITToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aToolStripMenuItem.Text = "Load";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem2.Text = "PUBG";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cSGOToolStripMenuItem
            // 
            this.cSGOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRIMEToolStripMenuItem,
            this.iNV50ToolStripMenuItem,
            this.vACToolStripMenuItem});
            this.cSGOToolStripMenuItem.Name = "cSGOToolStripMenuItem";
            this.cSGOToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cSGOToolStripMenuItem.Text = "CS:GO";
            this.cSGOToolStripMenuItem.Click += new System.EventHandler(this.cSGOToolStripMenuItem_Click);
            // 
            // pRIMEToolStripMenuItem
            // 
            this.pRIMEToolStripMenuItem.Name = "pRIMEToolStripMenuItem";
            this.pRIMEToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pRIMEToolStripMenuItem.Text = "PRIME";
            this.pRIMEToolStripMenuItem.Click += new System.EventHandler(this.pRIMEToolStripMenuItem_Click);
            // 
            // iNV50ToolStripMenuItem
            // 
            this.iNV50ToolStripMenuItem.Name = "iNV50ToolStripMenuItem";
            this.iNV50ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.iNV50ToolStripMenuItem.Text = "INV>50";
            this.iNV50ToolStripMenuItem.Click += new System.EventHandler(this.iNV50ToolStripMenuItem_Click);
            // 
            // vACToolStripMenuItem
            // 
            this.vACToolStripMenuItem.Name = "vACToolStripMenuItem";
            this.vACToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.vACToolStripMenuItem.Text = "VAC";
            this.vACToolStripMenuItem.Click += new System.EventHandler(this.vACToolStripMenuItem_Click);
            // 
            // gTAVToolStripMenuItem
            // 
            this.gTAVToolStripMenuItem.Name = "gTAVToolStripMenuItem";
            this.gTAVToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gTAVToolStripMenuItem.Text = "GTA V";
            this.gTAVToolStripMenuItem.Click += new System.EventHandler(this.gTAVToolStripMenuItem_Click);
            // 
            // rUSTToolStripMenuItem
            // 
            this.rUSTToolStripMenuItem.Name = "rUSTToolStripMenuItem";
            this.rUSTToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rUSTToolStripMenuItem.Text = "RUST";
            this.rUSTToolStripMenuItem.Click += new System.EventHandler(this.rUSTToolStripMenuItem_Click);
            // 
            // rOCKETLEAGUEToolStripMenuItem
            // 
            this.rOCKETLEAGUEToolStripMenuItem.Name = "rOCKETLEAGUEToolStripMenuItem";
            this.rOCKETLEAGUEToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rOCKETLEAGUEToolStripMenuItem.Text = "ROCKET LEAGUE";
            this.rOCKETLEAGUEToolStripMenuItem.Click += new System.EventHandler(this.rOCKETLEAGUEToolStripMenuItem_Click);
            // 
            // lIMITToolStripMenuItem
            // 
            this.lIMITToolStripMenuItem.Name = "lIMITToolStripMenuItem";
            this.lIMITToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lIMITToolStripMenuItem.Text = "LIMIT";
            this.lIMITToolStripMenuItem.Click += new System.EventHandler(this.lIMITToolStripMenuItem_Click);
            // 
            // nOLIMITToolStripMenuItem
            // 
            this.nOLIMITToolStripMenuItem.Name = "nOLIMITToolStripMenuItem";
            this.nOLIMITToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nOLIMITToolStripMenuItem.Text = "NO LIMIT";
            this.nOLIMITToolStripMenuItem.Click += new System.EventHandler(this.nOLIMITToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            this.toolStripMenuItem1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 998);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Account Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cSGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRIMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNV50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gTAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOCKETLEAGUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIMITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOLIMITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vACToolStripMenuItem;

        #endregion
        //private ListViewColumnSorter lvwColumnSorter;
    }

}

