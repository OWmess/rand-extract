namespace RandomExtract
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.go_button = new System.Windows.Forms.Button();
            this.main_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.setting_button = new RandomExtract.ImageButton();
            this.minimize_button = new RandomExtract.ImageButton();
            this.close_button = new RandomExtract.ImageButton();
            this.choosedList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // go_button
            // 
            this.go_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.go_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.go_button.Location = new System.Drawing.Point(65, 193);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(317, 71);
            this.go_button.TabIndex = 0;
            this.go_button.Text = "开始";
            this.go_button.UseVisualStyleBackColor = false;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // main_lable
            // 
            this.main_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 84.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main_lable.Location = new System.Drawing.Point(-6, 48);
            this.main_lable.Name = "main_lable";
            this.main_lable.Size = new System.Drawing.Size(463, 151);
            this.main_lable.TabIndex = 1;
            this.main_lable.Text = "准备";
            this.main_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_lable.UseMnemonic = false;
            this.main_lable.Click += new System.EventHandler(this.main_lable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.setting_button);
            this.panel1.Controls.Add(this.minimize_button);
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 47);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.title.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(124, 47);
            this.title.TabIndex = 3;
            this.title.Text = "随机抽号器";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setting_button
            // 
            this.setting_button.BackColor = System.Drawing.Color.Transparent;
            this.setting_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.setting_button.DownImage = global::RandomExtract.Properties.Resources.设置;
            this.setting_button.HoverImage = global::RandomExtract.Properties.Resources.设置__悬停;
            this.setting_button.Location = new System.Drawing.Point(363, 12);
            this.setting_button.Name = "setting_button";
            this.setting_button.NormalImage = global::RandomExtract.Properties.Resources.设置;
            this.setting_button.Size = new System.Drawing.Size(25, 23);
            this.setting_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setting_button.TabIndex = 2;
            this.setting_button.TabStop = false;
            this.setting_button.Text = "imageButton2";
            this.setting_button.ToolTipText = null;
            this.setting_button.Click += new System.EventHandler(this.setting_button_Click);
            this.setting_button.MouseEnter += new System.EventHandler(this.setting_button_MouseEnter);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.minimize_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minimize_button.DownImage = global::RandomExtract.Properties.Resources.最小化;
            this.minimize_button.HoverImage = global::RandomExtract.Properties.Resources.最小化_悬停;
            this.minimize_button.Location = new System.Drawing.Point(394, 12);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.NormalImage = global::RandomExtract.Properties.Resources.最小化;
            this.minimize_button.Size = new System.Drawing.Size(24, 23);
            this.minimize_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_button.TabIndex = 1;
            this.minimize_button.TabStop = false;
            this.minimize_button.Text = "imageButton1";
            this.minimize_button.ToolTipText = null;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            this.minimize_button.MouseEnter += new System.EventHandler(this.minimize_button_MouseEnter);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.close_button.DownImage = global::RandomExtract.Properties.Resources.关闭;
            this.close_button.HoverImage = ((System.Drawing.Image)(resources.GetObject("close_button.HoverImage")));
            this.close_button.Location = new System.Drawing.Point(424, 12);
            this.close_button.Name = "close_button";
            this.close_button.NormalImage = global::RandomExtract.Properties.Resources.关闭;
            this.close_button.Size = new System.Drawing.Size(25, 23);
            this.close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_button.TabIndex = 0;
            this.close_button.TabStop = false;
            this.close_button.Text = "imageButton1";
            this.close_button.ToolTipText = null;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            this.close_button.MouseEnter += new System.EventHandler(this.close_button_MouseEnter);
            // 
            // choosedList
            // 
            this.choosedList.BackColor = System.Drawing.SystemColors.Control;
            this.choosedList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.choosedList.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choosedList.Location = new System.Drawing.Point(0, 317);
            this.choosedList.Name = "choosedList";
            this.choosedList.Size = new System.Drawing.Size(457, 230);
            this.choosedList.TabIndex = 4;
            this.choosedList.Click += new System.EventHandler(this.choosedList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "天选之子：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(388, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(402, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 23);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "v1.0.0";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RandomExtract.Properties.Resources.school;
            this.pictureBox2.Location = new System.Drawing.Point(2, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 545);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosedList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_lable);
            this.Controls.Add(this.go_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomExtract";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setting_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.Label main_lable;
        private System.Windows.Forms.Panel panel1;
        private ImageButton close_button;
        private ImageButton minimize_button;
        private ImageButton setting_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label choosedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

