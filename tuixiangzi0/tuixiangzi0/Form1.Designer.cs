namespace tuixiangzi0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLeveln = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重玩本关ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关卡选择toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一关ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.退出游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(72, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtLeveln
            // 
            this.txtLeveln.BackColor = System.Drawing.SystemColors.Control;
            this.txtLeveln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeveln.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLeveln.Enabled = false;
            this.txtLeveln.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeveln.ForeColor = System.Drawing.Color.Red;
            this.txtLeveln.Location = new System.Drawing.Point(223, 51);
            this.txtLeveln.Name = "txtLeveln";
            this.txtLeveln.Size = new System.Drawing.Size(126, 55);
            this.txtLeveln.TabIndex = 6;
            this.txtLeveln.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "当前关卡：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 32);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.重玩本关ToolStripMenuItem,
            this.关卡选择toolStripMenuItem,
            this.下一关ToolStripMenuItem,
            this.tsmEdit,
            this.退出游戏ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.撤销ToolStripMenuItem.Text = "撤销 (c)";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // 重玩本关ToolStripMenuItem
            // 
            this.重玩本关ToolStripMenuItem.Name = "重玩本关ToolStripMenuItem";
            this.重玩本关ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.重玩本关ToolStripMenuItem.Text = "重玩本关";
            this.重玩本关ToolStripMenuItem.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // 关卡选择toolStripMenuItem
            // 
            this.关卡选择toolStripMenuItem.Name = "关卡选择toolStripMenuItem";
            this.关卡选择toolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.关卡选择toolStripMenuItem.Text = "关卡选择";
            // 
            // 下一关ToolStripMenuItem
            // 
            this.下一关ToolStripMenuItem.Name = "下一关ToolStripMenuItem";
            this.下一关ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.下一关ToolStripMenuItem.Text = "下一关";
            this.下一关ToolStripMenuItem.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(210, 30);
            this.tsmEdit.Text = "关卡编辑";
            this.tsmEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // 退出游戏ToolStripMenuItem
            // 
            this.退出游戏ToolStripMenuItem.Name = "退出游戏ToolStripMenuItem";
            this.退出游戏ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.退出游戏ToolStripMenuItem.Text = "退出游戏";
            this.退出游戏ToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(598, 644);
            this.Controls.Add(this.txtLeveln);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "推箱子";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PreviewKeydown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeveln;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重玩本关ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一关ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关卡选择toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
    }
}

