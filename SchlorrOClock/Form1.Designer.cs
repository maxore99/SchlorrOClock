
namespace SchlorrOClock
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBOX = new System.Windows.Forms.PictureBox();
            this.timTIME = new System.Windows.Forms.Timer(this.components);
            this.mnuTime = new System.Windows.Forms.MenuStrip();
            this.TimeZoneItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBOX)).BeginInit();
            this.mnuTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBOX
            // 
            this.picBOX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBOX.Location = new System.Drawing.Point(12, 0);
            this.picBOX.Name = "picBOX";
            this.picBOX.Size = new System.Drawing.Size(450, 450);
            this.picBOX.TabIndex = 0;
            this.picBOX.TabStop = false;
            this.picBOX.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timTIME
            // 
            this.timTIME.Enabled = true;
            this.timTIME.Interval = 1000;
            this.timTIME.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mnuTime
            // 
            this.mnuTime.AutoSize = false;
            this.mnuTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuTime.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeZoneItem});
            this.mnuTime.Location = new System.Drawing.Point(0, 0);
            this.mnuTime.Name = "mnuTime";
            this.mnuTime.Size = new System.Drawing.Size(91, 25);
            this.mnuTime.TabIndex = 1;
            this.mnuTime.Text = "menuStrip1";
            // 
            // TimeZoneItem
            // 
            this.TimeZoneItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gMTToolStripMenuItem,
            this.bSTToolStripMenuItem,
            this.eDTToolStripMenuItem1,
            this.pDTToolStripMenuItem,
            this.cESTToolStripMenuItem,
            this.cSTToolStripMenuItem});
            this.TimeZoneItem.Name = "TimeZoneItem";
            this.TimeZoneItem.Size = new System.Drawing.Size(75, 21);
            this.TimeZoneItem.Text = "Time Zone";
            // 
            // gMTToolStripMenuItem
            // 
            this.gMTToolStripMenuItem.Name = "gMTToolStripMenuItem";
            this.gMTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gMTToolStripMenuItem.Text = "GMT";
            this.gMTToolStripMenuItem.Click += new System.EventHandler(this.gMTToolStripMenuItem_Click_1);
            // 
            // bSTToolStripMenuItem
            // 
            this.bSTToolStripMenuItem.Checked = true;
            this.bSTToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bSTToolStripMenuItem.Name = "bSTToolStripMenuItem";
            this.bSTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bSTToolStripMenuItem.Text = "BST";
            this.bSTToolStripMenuItem.Click += new System.EventHandler(this.bSTToolStripMenuItem_Click_1);
            // 
            // eDTToolStripMenuItem1
            // 
            this.eDTToolStripMenuItem1.Name = "eDTToolStripMenuItem1";
            this.eDTToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eDTToolStripMenuItem1.Text = "EDT";
            this.eDTToolStripMenuItem1.Click += new System.EventHandler(this.eDTToolStripMenuItem1_Click);
            // 
            // pDTToolStripMenuItem
            // 
            this.pDTToolStripMenuItem.Name = "pDTToolStripMenuItem";
            this.pDTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pDTToolStripMenuItem.Text = "PDT";
            this.pDTToolStripMenuItem.Click += new System.EventHandler(this.pDTToolStripMenuItem_Click_1);
            // 
            // cESTToolStripMenuItem
            // 
            this.cESTToolStripMenuItem.Name = "cESTToolStripMenuItem";
            this.cESTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cESTToolStripMenuItem.Text = "CEST";
            this.cESTToolStripMenuItem.Click += new System.EventHandler(this.cESTToolStripMenuItem_Click_1);
            // 
            // cSTToolStripMenuItem
            // 
            this.cSTToolStripMenuItem.Name = "cSTToolStripMenuItem";
            this.cSTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cSTToolStripMenuItem.Text = "CST";
            this.cSTToolStripMenuItem.Click += new System.EventHandler(this.cSTToolStripMenuItem_Click_1);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.mnuTime);
            this.Controls.Add(this.picBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuTime;
            this.Name = "form1";
            this.Text = "SchlorrOClock";
            ((System.ComponentModel.ISupportInitialize)(this.picBOX)).EndInit();
            this.mnuTime.ResumeLayout(false);
            this.mnuTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBOX;
        private System.Windows.Forms.Timer timTIME;
        private System.Windows.Forms.MenuStrip mnuTime;
        private System.Windows.Forms.ToolStripMenuItem TimeZoneItem;
        private System.Windows.Forms.ToolStripMenuItem gMTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pDTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSTToolStripMenuItem;
    }
}

