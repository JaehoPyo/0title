namespace CVC
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCVStatus = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbBuff30Exist = new System.Windows.Forms.CheckBox();
            this.cbEmergency = new System.Windows.Forms.CheckBox();
            this.cbNone1 = new System.Windows.Forms.CheckBox();
            this.cbBuff40Full = new System.Windows.Forms.CheckBox();
            this.cbAutoRun = new System.Windows.Forms.CheckBox();
            this.cbBuff30Full = new System.Windows.Forms.CheckBox();
            this.cbManual = new System.Windows.Forms.CheckBox();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tmRequestStatus = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbNone5 = new System.Windows.Forms.CheckBox();
            this.cbTurnPallet = new System.Windows.Forms.CheckBox();
            this.cbNone4 = new System.Windows.Forms.CheckBox();
            this.cbNone3 = new System.Windows.Forms.CheckBox();
            this.cbStraight2Finish = new System.Windows.Forms.CheckBox();
            this.cbBuff40Exist = new System.Windows.Forms.CheckBox();
            this.cbNone2 = new System.Windows.Forms.CheckBox();
            this.cbAlarm = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbNone9 = new System.Windows.Forms.CheckBox();
            this.cbBuff11Ready = new System.Windows.Forms.CheckBox();
            this.cbNone8 = new System.Windows.Forms.CheckBox();
            this.cbNone7 = new System.Windows.Forms.CheckBox();
            this.cbBuff11Exist = new System.Windows.Forms.CheckBox();
            this.cbNone6 = new System.Windows.Forms.CheckBox();
            this.cbStraightFinish = new System.Windows.Forms.CheckBox();
            this.cbTurnFinish = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbNone13 = new System.Windows.Forms.CheckBox();
            this.cbNone14 = new System.Windows.Forms.CheckBox();
            this.cbNone12 = new System.Windows.Forms.CheckBox();
            this.cbNone11 = new System.Windows.Forms.CheckBox();
            this.cbStraight2Exist = new System.Windows.Forms.CheckBox();
            this.cbNone10 = new System.Windows.Forms.CheckBox();
            this.cbBuff2Ready = new System.Windows.Forms.CheckBox();
            this.cbBuff2Exist = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCVStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 589);
            this.panel1.TabIndex = 0;
            // 
            // tbCVStatus
            // 
            this.tbCVStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCVStatus.Location = new System.Drawing.Point(0, 0);
            this.tbCVStatus.Multiline = true;
            this.tbCVStatus.Name = "tbCVStatus";
            this.tbCVStatus.Size = new System.Drawing.Size(440, 589);
            this.tbCVStatus.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(440, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 589);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbBuff30Exist);
            this.panel4.Controls.Add(this.cbEmergency);
            this.panel4.Controls.Add(this.cbNone1);
            this.panel4.Controls.Add(this.cbBuff40Full);
            this.panel4.Controls.Add(this.cbAutoRun);
            this.panel4.Controls.Add(this.cbBuff30Full);
            this.panel4.Controls.Add(this.cbManual);
            this.panel4.Controls.Add(this.cbAuto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 115);
            this.panel4.TabIndex = 2;
            // 
            // cbBuff30Exist
            // 
            this.cbBuff30Exist.AutoSize = true;
            this.cbBuff30Exist.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBuff30Exist.Location = new System.Drawing.Point(172, 83);
            this.cbBuff30Exist.Name = "cbBuff30Exist";
            this.cbBuff30Exist.Size = new System.Drawing.Size(149, 19);
            this.cbBuff30Exist.TabIndex = 1;
            this.cbBuff30Exist.Text = "1층 출고대 화물유";
            this.cbBuff30Exist.UseVisualStyleBackColor = true;
            // 
            // cbEmergency
            // 
            this.cbEmergency.AutoSize = true;
            this.cbEmergency.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbEmergency.Location = new System.Drawing.Point(20, 83);
            this.cbEmergency.Name = "cbEmergency";
            this.cbEmergency.Size = new System.Drawing.Size(104, 19);
            this.cbEmergency.TabIndex = 1;
            this.cbEmergency.Text = "CV비상정지";
            this.cbEmergency.UseVisualStyleBackColor = true;
            // 
            // cbNone1
            // 
            this.cbNone1.AutoSize = true;
            this.cbNone1.Enabled = false;
            this.cbNone1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone1.Location = new System.Drawing.Point(172, 57);
            this.cbNone1.Name = "cbNone1";
            this.cbNone1.Size = new System.Drawing.Size(34, 19);
            this.cbNone1.TabIndex = 0;
            this.cbNone1.Text = "-";
            this.cbNone1.UseVisualStyleBackColor = true;
            // 
            // cbBuff40Full
            // 
            this.cbBuff40Full.AutoSize = true;
            this.cbBuff40Full.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBuff40Full.Location = new System.Drawing.Point(172, 31);
            this.cbBuff40Full.Name = "cbBuff40Full";
            this.cbBuff40Full.Size = new System.Drawing.Size(137, 19);
            this.cbBuff40Full.TabIndex = 1;
            this.cbBuff40Full.Text = "출하CV 2층 만재";
            this.cbBuff40Full.UseVisualStyleBackColor = true;
            // 
            // cbAutoRun
            // 
            this.cbAutoRun.AutoSize = true;
            this.cbAutoRun.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAutoRun.Location = new System.Drawing.Point(20, 57);
            this.cbAutoRun.Name = "cbAutoRun";
            this.cbAutoRun.Size = new System.Drawing.Size(119, 19);
            this.cbAutoRun.TabIndex = 0;
            this.cbAutoRun.Text = "CV자동운전중";
            this.cbAutoRun.UseVisualStyleBackColor = true;
            // 
            // cbBuff30Full
            // 
            this.cbBuff30Full.AutoSize = true;
            this.cbBuff30Full.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBuff30Full.Location = new System.Drawing.Point(172, 5);
            this.cbBuff30Full.Name = "cbBuff30Full";
            this.cbBuff30Full.Size = new System.Drawing.Size(137, 19);
            this.cbBuff30Full.TabIndex = 0;
            this.cbBuff30Full.Text = "출하CV 1층 만재";
            this.cbBuff30Full.UseVisualStyleBackColor = true;
            // 
            // cbManual
            // 
            this.cbManual.AutoSize = true;
            this.cbManual.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbManual.Location = new System.Drawing.Point(20, 31);
            this.cbManual.Name = "cbManual";
            this.cbManual.Size = new System.Drawing.Size(74, 19);
            this.cbManual.TabIndex = 1;
            this.cbManual.Text = "CV수동";
            this.cbManual.UseVisualStyleBackColor = true;
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAuto.Location = new System.Drawing.Point(20, 5);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(74, 19);
            this.cbAuto.TabIndex = 0;
            this.cbAuto.Text = "CV자동";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 39);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "컨베이어상태";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(21, 532);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tmRequestStatus
            // 
            this.tmRequestStatus.Interval = 2000;
            this.tmRequestStatus.Tick += new System.EventHandler(this.tmRequestStatus_Tick);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cbNone5);
            this.panel5.Controls.Add(this.cbTurnPallet);
            this.panel5.Controls.Add(this.cbNone4);
            this.panel5.Controls.Add(this.cbNone3);
            this.panel5.Controls.Add(this.cbStraight2Finish);
            this.panel5.Controls.Add(this.cbBuff40Exist);
            this.panel5.Controls.Add(this.cbNone2);
            this.panel5.Controls.Add(this.cbAlarm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 154);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 115);
            this.panel5.TabIndex = 3;
            // 
            // cbNone5
            // 
            this.cbNone5.AutoSize = true;
            this.cbNone5.Enabled = false;
            this.cbNone5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone5.Location = new System.Drawing.Point(172, 83);
            this.cbNone5.Name = "cbNone5";
            this.cbNone5.Size = new System.Drawing.Size(34, 19);
            this.cbNone5.TabIndex = 1;
            this.cbNone5.Text = "-";
            this.cbNone5.UseVisualStyleBackColor = true;
            // 
            // cbTurnPallet
            // 
            this.cbTurnPallet.AutoSize = true;
            this.cbTurnPallet.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbTurnPallet.Location = new System.Drawing.Point(20, 83);
            this.cbTurnPallet.Name = "cbTurnPallet";
            this.cbTurnPallet.Size = new System.Drawing.Size(138, 19);
            this.cbTurnPallet.TabIndex = 1;
            this.cbTurnPallet.Text = "분기점PALLET유";
            this.cbTurnPallet.UseVisualStyleBackColor = true;
            // 
            // cbNone4
            // 
            this.cbNone4.AutoSize = true;
            this.cbNone4.Enabled = false;
            this.cbNone4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone4.Location = new System.Drawing.Point(172, 57);
            this.cbNone4.Name = "cbNone4";
            this.cbNone4.Size = new System.Drawing.Size(34, 19);
            this.cbNone4.TabIndex = 0;
            this.cbNone4.Text = "-";
            this.cbNone4.UseVisualStyleBackColor = true;
            // 
            // cbNone3
            // 
            this.cbNone3.AutoSize = true;
            this.cbNone3.Enabled = false;
            this.cbNone3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone3.Location = new System.Drawing.Point(172, 31);
            this.cbNone3.Name = "cbNone3";
            this.cbNone3.Size = new System.Drawing.Size(34, 19);
            this.cbNone3.TabIndex = 1;
            this.cbNone3.Text = "-";
            this.cbNone3.UseVisualStyleBackColor = true;
            // 
            // cbStraight2Finish
            // 
            this.cbStraight2Finish.AutoSize = true;
            this.cbStraight2Finish.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbStraight2Finish.Location = new System.Drawing.Point(20, 57);
            this.cbStraight2Finish.Name = "cbStraight2Finish";
            this.cbStraight2Finish.Size = new System.Drawing.Size(99, 19);
            this.cbStraight2Finish.TabIndex = 0;
            this.cbStraight2Finish.Text = "직진2 완료";
            this.cbStraight2Finish.UseVisualStyleBackColor = true;
            // 
            // cbBuff40Exist
            // 
            this.cbBuff40Exist.AutoSize = true;
            this.cbBuff40Exist.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBuff40Exist.Location = new System.Drawing.Point(172, 5);
            this.cbBuff40Exist.Name = "cbBuff40Exist";
            this.cbBuff40Exist.Size = new System.Drawing.Size(149, 19);
            this.cbBuff40Exist.TabIndex = 0;
            this.cbBuff40Exist.Text = "2층 출고대 화물유";
            this.cbBuff40Exist.UseVisualStyleBackColor = true;
            // 
            // cbNone2
            // 
            this.cbNone2.AutoSize = true;
            this.cbNone2.Enabled = false;
            this.cbNone2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone2.Location = new System.Drawing.Point(20, 31);
            this.cbNone2.Name = "cbNone2";
            this.cbNone2.Size = new System.Drawing.Size(34, 19);
            this.cbNone2.TabIndex = 1;
            this.cbNone2.Text = "-";
            this.cbNone2.UseVisualStyleBackColor = true;
            // 
            // cbAlarm
            // 
            this.cbAlarm.AutoSize = true;
            this.cbAlarm.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAlarm.Location = new System.Drawing.Point(20, 5);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(74, 19);
            this.cbAlarm.TabIndex = 0;
            this.cbAlarm.Text = "CV알람";
            this.cbAlarm.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbNone9);
            this.panel6.Controls.Add(this.cbBuff11Ready);
            this.panel6.Controls.Add(this.cbNone8);
            this.panel6.Controls.Add(this.cbNone7);
            this.panel6.Controls.Add(this.cbBuff11Exist);
            this.panel6.Controls.Add(this.cbNone6);
            this.panel6.Controls.Add(this.cbStraightFinish);
            this.panel6.Controls.Add(this.cbTurnFinish);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 269);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 115);
            this.panel6.TabIndex = 4;
            // 
            // cbNone9
            // 
            this.cbNone9.AutoSize = true;
            this.cbNone9.Enabled = false;
            this.cbNone9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone9.Location = new System.Drawing.Point(172, 83);
            this.cbNone9.Name = "cbNone9";
            this.cbNone9.Size = new System.Drawing.Size(34, 19);
            this.cbNone9.TabIndex = 1;
            this.cbNone9.Text = "-";
            this.cbNone9.UseVisualStyleBackColor = true;
            // 
            // cbBuff11Ready
            // 
            this.cbBuff11Ready.AutoSize = true;
            this.cbBuff11Ready.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBuff11Ready.Location = new System.Drawing.Point(20, 83);
            this.cbBuff11Ready.Name = "cbBuff11Ready";
            this.cbBuff11Ready.Size = new System.Drawing.Size(128, 19);
            this.cbBuff11Ready.TabIndex = 1;
            this.cbBuff11Ready.Text = "입고 #1 READY";
            this.cbBuff11Ready.UseVisualStyleBackColor = true;
            // 
            // cbNone8
            // 
            this.cbNone8.AutoSize = true;
            this.cbNone8.Enabled = false;
            this.cbNone8.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone8.Location = new System.Drawing.Point(172, 57);
            this.cbNone8.Name = "cbNone8";
            this.cbNone8.Size = new System.Drawing.Size(34, 19);
            this.cbNone8.TabIndex = 0;
            this.cbNone8.Text = "-";
            this.cbNone8.UseVisualStyleBackColor = true;
            // 
            // cbNone7
            // 
            this.cbNone7.AutoSize = true;
            this.cbNone7.Enabled = false;
            this.cbNone7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone7.Location = new System.Drawing.Point(172, 31);
            this.cbNone7.Name = "cbNone7";
            this.cbNone7.Size = new System.Drawing.Size(34, 19);
            this.cbNone7.TabIndex = 1;
            this.cbNone7.Text = "-";
            this.cbNone7.UseVisualStyleBackColor = true;
            // 
            // cbBuff11Exist
            // 
            this.cbBuff11Exist.AutoSize = true;
            this.cbBuff11Exist.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBuff11Exist.Location = new System.Drawing.Point(20, 57);
            this.cbBuff11Exist.Name = "cbBuff11Exist";
            this.cbBuff11Exist.Size = new System.Drawing.Size(149, 19);
            this.cbBuff11Exist.TabIndex = 0;
            this.cbBuff11Exist.Text = "입고 #1 PALLET유";
            this.cbBuff11Exist.UseVisualStyleBackColor = true;
            // 
            // cbNone6
            // 
            this.cbNone6.AutoSize = true;
            this.cbNone6.Enabled = false;
            this.cbNone6.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone6.Location = new System.Drawing.Point(172, 5);
            this.cbNone6.Name = "cbNone6";
            this.cbNone6.Size = new System.Drawing.Size(34, 19);
            this.cbNone6.TabIndex = 0;
            this.cbNone6.Text = "-";
            this.cbNone6.UseVisualStyleBackColor = true;
            // 
            // cbStraightFinish
            // 
            this.cbStraightFinish.AutoSize = true;
            this.cbStraightFinish.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbStraightFinish.Location = new System.Drawing.Point(20, 31);
            this.cbStraightFinish.Name = "cbStraightFinish";
            this.cbStraightFinish.Size = new System.Drawing.Size(86, 19);
            this.cbStraightFinish.TabIndex = 1;
            this.cbStraightFinish.Text = "직진완료";
            this.cbStraightFinish.UseVisualStyleBackColor = true;
            // 
            // cbTurnFinish
            // 
            this.cbTurnFinish.AutoSize = true;
            this.cbTurnFinish.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbTurnFinish.Location = new System.Drawing.Point(20, 5);
            this.cbTurnFinish.Name = "cbTurnFinish";
            this.cbTurnFinish.Size = new System.Drawing.Size(86, 19);
            this.cbTurnFinish.TabIndex = 0;
            this.cbTurnFinish.Text = "분기완료";
            this.cbTurnFinish.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.cbNone13);
            this.panel7.Controls.Add(this.cbNone14);
            this.panel7.Controls.Add(this.cbNone12);
            this.panel7.Controls.Add(this.cbNone11);
            this.panel7.Controls.Add(this.cbStraight2Exist);
            this.panel7.Controls.Add(this.cbNone10);
            this.panel7.Controls.Add(this.cbBuff2Ready);
            this.panel7.Controls.Add(this.cbBuff2Exist);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 384);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(332, 115);
            this.panel7.TabIndex = 5;
            // 
            // cbNone13
            // 
            this.cbNone13.AutoSize = true;
            this.cbNone13.Enabled = false;
            this.cbNone13.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone13.Location = new System.Drawing.Point(172, 83);
            this.cbNone13.Name = "cbNone13";
            this.cbNone13.Size = new System.Drawing.Size(34, 19);
            this.cbNone13.TabIndex = 1;
            this.cbNone13.Text = "-";
            this.cbNone13.UseVisualStyleBackColor = true;
            // 
            // cbNone14
            // 
            this.cbNone14.AutoSize = true;
            this.cbNone14.Enabled = false;
            this.cbNone14.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone14.Location = new System.Drawing.Point(20, 83);
            this.cbNone14.Name = "cbNone14";
            this.cbNone14.Size = new System.Drawing.Size(34, 19);
            this.cbNone14.TabIndex = 1;
            this.cbNone14.Text = "-";
            this.cbNone14.UseVisualStyleBackColor = true;
            // 
            // cbNone12
            // 
            this.cbNone12.AutoSize = true;
            this.cbNone12.Enabled = false;
            this.cbNone12.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone12.Location = new System.Drawing.Point(172, 57);
            this.cbNone12.Name = "cbNone12";
            this.cbNone12.Size = new System.Drawing.Size(34, 19);
            this.cbNone12.TabIndex = 0;
            this.cbNone12.Text = "-";
            this.cbNone12.UseVisualStyleBackColor = true;
            // 
            // cbNone11
            // 
            this.cbNone11.AutoSize = true;
            this.cbNone11.Enabled = false;
            this.cbNone11.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone11.Location = new System.Drawing.Point(172, 31);
            this.cbNone11.Name = "cbNone11";
            this.cbNone11.Size = new System.Drawing.Size(34, 19);
            this.cbNone11.TabIndex = 1;
            this.cbNone11.Text = "-";
            this.cbNone11.UseVisualStyleBackColor = true;
            // 
            // cbStraight2Exist
            // 
            this.cbStraight2Exist.AutoSize = true;
            this.cbStraight2Exist.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbStraight2Exist.Location = new System.Drawing.Point(20, 57);
            this.cbStraight2Exist.Name = "cbStraight2Exist";
            this.cbStraight2Exist.Size = new System.Drawing.Size(136, 19);
            this.cbStraight2Exist.TabIndex = 0;
            this.cbStraight2Exist.Text = "직진2 PALLET유";
            this.cbStraight2Exist.UseVisualStyleBackColor = true;
            // 
            // cbNone10
            // 
            this.cbNone10.AutoSize = true;
            this.cbNone10.Enabled = false;
            this.cbNone10.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbNone10.Location = new System.Drawing.Point(172, 5);
            this.cbNone10.Name = "cbNone10";
            this.cbNone10.Size = new System.Drawing.Size(34, 19);
            this.cbNone10.TabIndex = 0;
            this.cbNone10.Text = "-";
            this.cbNone10.UseVisualStyleBackColor = true;
            // 
            // cbBuff2Ready
            // 
            this.cbBuff2Ready.AutoSize = true;
            this.cbBuff2Ready.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBuff2Ready.Location = new System.Drawing.Point(20, 31);
            this.cbBuff2Ready.Name = "cbBuff2Ready";
            this.cbBuff2Ready.Size = new System.Drawing.Size(128, 19);
            this.cbBuff2Ready.TabIndex = 1;
            this.cbBuff2Ready.Text = "입고 #2 READY";
            this.cbBuff2Ready.UseVisualStyleBackColor = true;
            // 
            // cbBuff2Exist
            // 
            this.cbBuff2Exist.AutoSize = true;
            this.cbBuff2Exist.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBuff2Exist.Location = new System.Drawing.Point(20, 5);
            this.cbBuff2Exist.Name = "cbBuff2Exist";
            this.cbBuff2Exist.Size = new System.Drawing.Size(149, 19);
            this.cbBuff2Exist.TabIndex = 0;
            this.cbBuff2Exist.Text = "입고 #2 PALLET유";
            this.cbBuff2Exist.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "CVC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCVStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer tmRequestStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbManual;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.CheckBox cbEmergency;
        private System.Windows.Forms.CheckBox cbAutoRun;
        private System.Windows.Forms.CheckBox cbBuff30Exist;
        private System.Windows.Forms.CheckBox cbNone1;
        private System.Windows.Forms.CheckBox cbBuff40Full;
        private System.Windows.Forms.CheckBox cbBuff30Full;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox cbNone5;
        private System.Windows.Forms.CheckBox cbTurnPallet;
        private System.Windows.Forms.CheckBox cbNone4;
        private System.Windows.Forms.CheckBox cbNone3;
        private System.Windows.Forms.CheckBox cbStraight2Finish;
        private System.Windows.Forms.CheckBox cbBuff40Exist;
        private System.Windows.Forms.CheckBox cbNone2;
        private System.Windows.Forms.CheckBox cbAlarm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cbNone9;
        private System.Windows.Forms.CheckBox cbBuff11Ready;
        private System.Windows.Forms.CheckBox cbNone8;
        private System.Windows.Forms.CheckBox cbNone7;
        private System.Windows.Forms.CheckBox cbBuff11Exist;
        private System.Windows.Forms.CheckBox cbNone6;
        private System.Windows.Forms.CheckBox cbStraightFinish;
        private System.Windows.Forms.CheckBox cbTurnFinish;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cbNone13;
        private System.Windows.Forms.CheckBox cbNone14;
        private System.Windows.Forms.CheckBox cbNone12;
        private System.Windows.Forms.CheckBox cbNone11;
        private System.Windows.Forms.CheckBox cbStraight2Exist;
        private System.Windows.Forms.CheckBox cbNone10;
        private System.Windows.Forms.CheckBox cbBuff2Ready;
        private System.Windows.Forms.CheckBox cbBuff2Exist;
    }
}

