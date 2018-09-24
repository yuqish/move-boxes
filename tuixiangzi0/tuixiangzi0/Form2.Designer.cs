namespace tuixiangzi0
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLand = new System.Windows.Forms.ToolStripButton();
            this.tsbWall = new System.Windows.Forms.ToolStripButton();
            this.tsbBox = new System.Windows.Forms.ToolStripButton();
            this.tsbDest = new System.Windows.Forms.ToolStripButton();
            this.tsbBoD = new System.Windows.Forms.ToolStripButton();
            this.tsbMan = new System.Windows.Forms.ToolStripButton();
            this.tsbMoD = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关卡选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新关卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除关卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.默认10x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快捷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平铺墙ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeveln = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLand,
            this.tsbWall,
            this.tsbBox,
            this.tsbDest,
            this.tsbBoD,
            this.tsbMan,
            this.tsbMoD});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(598, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLand
            // 
            this.tsbLand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLand.Image = ((System.Drawing.Image)(resources.GetObject("tsbLand.Image")));
            this.tsbLand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLand.Name = "tsbLand";
            this.tsbLand.Size = new System.Drawing.Size(28, 28);
            this.tsbLand.Text = "空地";
            this.tsbLand.Click += new System.EventHandler(this.tsbLand_Click);
            // 
            // tsbWall
            // 
            this.tsbWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWall.Image = ((System.Drawing.Image)(resources.GetObject("tsbWall.Image")));
            this.tsbWall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWall.Name = "tsbWall";
            this.tsbWall.Size = new System.Drawing.Size(28, 28);
            this.tsbWall.Text = "墙";
            this.tsbWall.Click += new System.EventHandler(this.tsbWall_Click);
            // 
            // tsbBox
            // 
            this.tsbBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBox.Image = ((System.Drawing.Image)(resources.GetObject("tsbBox.Image")));
            this.tsbBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBox.Name = "tsbBox";
            this.tsbBox.Size = new System.Drawing.Size(28, 28);
            this.tsbBox.Text = "箱子";
            this.tsbBox.Click += new System.EventHandler(this.tsbBox_Click);
            // 
            // tsbDest
            // 
            this.tsbDest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDest.Image = ((System.Drawing.Image)(resources.GetObject("tsbDest.Image")));
            this.tsbDest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDest.Name = "tsbDest";
            this.tsbDest.Size = new System.Drawing.Size(28, 28);
            this.tsbDest.Text = "目的地";
            this.tsbDest.Click += new System.EventHandler(this.tsbDest_Click);
            // 
            // tsbBoD
            // 
            this.tsbBoD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBoD.Image = ((System.Drawing.Image)(resources.GetObject("tsbBoD.Image")));
            this.tsbBoD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBoD.Name = "tsbBoD";
            this.tsbBoD.Size = new System.Drawing.Size(28, 28);
            this.tsbBoD.Text = "箱子在目的地";
            this.tsbBoD.Click += new System.EventHandler(this.tsbBoD_Click);
            // 
            // tsbMan
            // 
            this.tsbMan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMan.Image = ((System.Drawing.Image)(resources.GetObject("tsbMan.Image")));
            this.tsbMan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMan.Name = "tsbMan";
            this.tsbMan.Size = new System.Drawing.Size(28, 28);
            this.tsbMan.Text = "人";
            this.tsbMan.Click += new System.EventHandler(this.tsbMan_Click);
            // 
            // tsbMoD
            // 
            this.tsbMoD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoD.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoD.Image")));
            this.tsbMoD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoD.Name = "tsbMoD";
            this.tsbMoD.Size = new System.Drawing.Size(28, 28);
            this.tsbMoD.Text = "人在目的地";
            this.tsbMoD.Click += new System.EventHandler(this.tsbMoD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.快捷ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关卡选择ToolStripMenuItem,
            this.新关卡ToolStripMenuItem,
            this.删除关卡ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.保存ToolStripMenuItem,
            this.退出编辑ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 关卡选择ToolStripMenuItem
            // 
            this.关卡选择ToolStripMenuItem.Name = "关卡选择ToolStripMenuItem";
            this.关卡选择ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.关卡选择ToolStripMenuItem.Text = "关卡选择";
            // 
            // 新关卡ToolStripMenuItem
            // 
            this.新关卡ToolStripMenuItem.Name = "新关卡ToolStripMenuItem";
            this.新关卡ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.新关卡ToolStripMenuItem.Text = "新关卡";
            this.新关卡ToolStripMenuItem.Click += new System.EventHandler(this.新关卡ToolStripMenuItem_Click);
            // 
            // 删除关卡ToolStripMenuItem
            // 
            this.删除关卡ToolStripMenuItem.Name = "删除关卡ToolStripMenuItem";
            this.删除关卡ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.删除关卡ToolStripMenuItem.Text = "删除关卡";
            this.删除关卡ToolStripMenuItem.Click += new System.EventHandler(this.删除关卡ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认10x10ToolStripMenuItem,
            this.x15ToolStripMenuItem,
            this.自定义ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 30);
            this.toolStripMenuItem1.Text = "地图尺寸";
            // 
            // 默认10x10ToolStripMenuItem
            // 
            this.默认10x10ToolStripMenuItem.Checked = true;
            this.默认10x10ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.默认10x10ToolStripMenuItem.Name = "默认10x10ToolStripMenuItem";
            this.默认10x10ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.默认10x10ToolStripMenuItem.Text = "默认 (10x10)";
            this.默认10x10ToolStripMenuItem.Click += new System.EventHandler(this.默认10x10ToolStripMenuItem_Click);
            // 
            // x15ToolStripMenuItem
            // 
            this.x15ToolStripMenuItem.Name = "x15ToolStripMenuItem";
            this.x15ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.x15ToolStripMenuItem.Text = "15x15";
            this.x15ToolStripMenuItem.Click += new System.EventHandler(this.x15ToolStripMenuItem_Click);
            // 
            // 自定义ToolStripMenuItem
            // 
            this.自定义ToolStripMenuItem.Name = "自定义ToolStripMenuItem";
            this.自定义ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.自定义ToolStripMenuItem.Text = "自定义";
            this.自定义ToolStripMenuItem.Click += new System.EventHandler(this.自定义ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 退出编辑ToolStripMenuItem
            // 
            this.退出编辑ToolStripMenuItem.Name = "退出编辑ToolStripMenuItem";
            this.退出编辑ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.退出编辑ToolStripMenuItem.Text = "退出编辑";
            this.退出编辑ToolStripMenuItem.Click += new System.EventHandler(this.退出编辑ToolStripMenuItem_Click);
            // 
            // 快捷ToolStripMenuItem
            // 
            this.快捷ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem,
            this.平铺墙ToolStripMenuItem});
            this.快捷ToolStripMenuItem.Name = "快捷ToolStripMenuItem";
            this.快捷ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.快捷ToolStripMenuItem.Text = "快捷";
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // 平铺墙ToolStripMenuItem
            // 
            this.平铺墙ToolStripMenuItem.Name = "平铺墙ToolStripMenuItem";
            this.平铺墙ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.平铺墙ToolStripMenuItem.Text = "平铺墙";
            this.平铺墙ToolStripMenuItem.Click += new System.EventHandler(this.平铺墙ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "当前关卡：";
            // 
            // txtLeveln
            // 
            this.txtLeveln.BackColor = System.Drawing.SystemColors.Control;
            this.txtLeveln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeveln.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLeveln.Enabled = false;
            this.txtLeveln.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeveln.ForeColor = System.Drawing.Color.Red;
            this.txtLeveln.Location = new System.Drawing.Point(499, 12);
            this.txtLeveln.Name = "txtLeveln";
            this.txtLeveln.Size = new System.Drawing.Size(87, 55);
            this.txtLeveln.TabIndex = 10;
            this.txtLeveln.Text = "1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(598, 644);
            this.Controls.Add(this.txtLeveln);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "关卡编辑";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_Close);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLand;
        private System.Windows.Forms.ToolStripButton tsbWall;
        private System.Windows.Forms.ToolStripButton tsbBox;
        private System.Windows.Forms.ToolStripButton tsbDest;
        private System.Windows.Forms.ToolStripButton tsbBoD;
        private System.Windows.Forms.ToolStripButton tsbMan;
        private System.Windows.Forms.ToolStripButton tsbMoD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关卡选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新关卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出编辑ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeveln;
        private System.Windows.Forms.ToolStripMenuItem 快捷ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平铺墙ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 默认10x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除关卡ToolStripMenuItem;
    }
}