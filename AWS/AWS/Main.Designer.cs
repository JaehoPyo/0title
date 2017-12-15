namespace AWS
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_310 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_240 = new System.Windows.Forms.Button();
            this.btn_230 = new System.Windows.Forms.Button();
            this.btn_220 = new System.Windows.Forms.Button();
            this.btn_210 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_120 = new System.Windows.Forms.Button();
            this.btn_110 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1264, 86);
            this.pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.Window;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLeft.Controls.Add(this.groupBox3);
            this.pnlLeft.Controls.Add(this.groupBox2);
            this.pnlLeft.Controls.Add(this.groupBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 86);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(3);
            this.pnlLeft.Size = new System.Drawing.Size(257, 899);
            this.pnlLeft.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btn_310);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(3, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 173);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "300. 재고관리";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 46);
            this.button2.TabIndex = 1;
            this.button2.Tag = "120";
            this.button2.Text = "U320";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_310
            // 
            this.btn_310.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_310.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_310.Image = ((System.Drawing.Image)(resources.GetObject("btn_310.Image")));
            this.btn_310.Location = new System.Drawing.Point(3, 22);
            this.btn_310.Name = "btn_310";
            this.btn_310.Size = new System.Drawing.Size(241, 46);
            this.btn_310.TabIndex = 0;
            this.btn_310.Tag = "310";
            this.btn_310.Text = "U310";
            this.btn_310.UseVisualStyleBackColor = true;
            this.btn_310.Click += new System.EventHandler(this.MenuClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_240);
            this.groupBox2.Controls.Add(this.btn_230);
            this.groupBox2.Controls.Add(this.btn_220);
            this.groupBox2.Controls.Add(this.btn_210);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(3, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "200. 작업관리";
            // 
            // btn_240
            // 
            this.btn_240.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_240.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_240.Image = ((System.Drawing.Image)(resources.GetObject("btn_240.Image")));
            this.btn_240.Location = new System.Drawing.Point(3, 160);
            this.btn_240.Name = "btn_240";
            this.btn_240.Size = new System.Drawing.Size(241, 46);
            this.btn_240.TabIndex = 3;
            this.btn_240.Tag = "240";
            this.btn_240.Text = "U240";
            this.btn_240.UseVisualStyleBackColor = true;
            this.btn_240.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_230
            // 
            this.btn_230.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_230.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_230.Image = ((System.Drawing.Image)(resources.GetObject("btn_230.Image")));
            this.btn_230.Location = new System.Drawing.Point(3, 114);
            this.btn_230.Name = "btn_230";
            this.btn_230.Size = new System.Drawing.Size(241, 46);
            this.btn_230.TabIndex = 2;
            this.btn_230.Tag = "230";
            this.btn_230.Text = "U230";
            this.btn_230.UseVisualStyleBackColor = true;
            // 
            // btn_220
            // 
            this.btn_220.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_220.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_220.Image = ((System.Drawing.Image)(resources.GetObject("btn_220.Image")));
            this.btn_220.Location = new System.Drawing.Point(3, 68);
            this.btn_220.Name = "btn_220";
            this.btn_220.Size = new System.Drawing.Size(241, 46);
            this.btn_220.TabIndex = 1;
            this.btn_220.Tag = "220";
            this.btn_220.Text = "U220";
            this.btn_220.UseVisualStyleBackColor = true;
            this.btn_220.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_210
            // 
            this.btn_210.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_210.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_210.Image = ((System.Drawing.Image)(resources.GetObject("btn_210.Image")));
            this.btn_210.Location = new System.Drawing.Point(3, 22);
            this.btn_210.Name = "btn_210";
            this.btn_210.Size = new System.Drawing.Size(241, 46);
            this.btn_210.TabIndex = 0;
            this.btn_210.Tag = "210";
            this.btn_210.Text = "U210";
            this.btn_210.UseVisualStyleBackColor = true;
            this.btn_210.Click += new System.EventHandler(this.MenuClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_120);
            this.groupBox1.Controls.Add(this.btn_110);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "100. 코드관리";
            // 
            // btn_120
            // 
            this.btn_120.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_120.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_120.Image = ((System.Drawing.Image)(resources.GetObject("btn_120.Image")));
            this.btn_120.Location = new System.Drawing.Point(3, 68);
            this.btn_120.Name = "btn_120";
            this.btn_120.Size = new System.Drawing.Size(241, 46);
            this.btn_120.TabIndex = 1;
            this.btn_120.Tag = "120";
            this.btn_120.Text = "U120";
            this.btn_120.UseVisualStyleBackColor = true;
            this.btn_120.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_110
            // 
            this.btn_110.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_110.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_110.Image = ((System.Drawing.Image)(resources.GetObject("btn_110.Image")));
            this.btn_110.Location = new System.Drawing.Point(3, 22);
            this.btn_110.Name = "btn_110";
            this.btn_110.Size = new System.Drawing.Size(241, 46);
            this.btn_110.TabIndex = 0;
            this.btn_110.Tag = "110";
            this.btn_110.Text = "U110";
            this.btn_110.UseVisualStyleBackColor = true;
            this.btn_110.Click += new System.EventHandler(this.MenuClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus1});
            this.statusStrip1.Location = new System.Drawing.Point(257, 963);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus1
            // 
            this.tsStatus1.Name = "tsStatus1";
            this.tsStatus1.Size = new System.Drawing.Size(121, 17);
            this.tsStatus1.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_110;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_120;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_220;
        private System.Windows.Forms.Button btn_210;
        private System.Windows.Forms.Button btn_240;
        private System.Windows.Forms.Button btn_230;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_310;
    }
}

