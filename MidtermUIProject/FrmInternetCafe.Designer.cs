namespace MidtermUIProject
{
    partial class FrmInternetCafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInternetCafe));
            label1 = new Label();
            groupBox1 = new GroupBox();
            mtbIDcard = new MaskedTextBox();
            tbnamelastname = new TextBox();
            RdoGeneral = new RadioButton();
            RdoStd = new RadioButton();
            RdoMember = new RadioButton();
            label3 = new Label();
            label18 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            groupBox2 = new GroupBox();
            tbUnit = new TextBox();
            CbbTypeUse = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            lblTotalPay = new Label();
            lblTypeuser = new Label();
            lblnamelastname = new Label();
            lblIDcard = new Label();
            lblDatetime = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btReNew = new Button();
            btCalculator = new Button();
            btEndProgram = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 19);
            label1.Name = "label1";
            label1.Size = new Size(326, 43);
            label1.TabIndex = 1;
            label1.Text = "โปรแกรม Internet Cafe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtbIDcard);
            groupBox1.Controls.Add(tbnamelastname);
            groupBox1.Controls.Add(RdoGeneral);
            groupBox1.Controls.Add(RdoStd);
            groupBox1.Controls.Add(RdoMember);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 237);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // mtbIDcard
            // 
            mtbIDcard.Location = new Point(418, 26);
            mtbIDcard.Mask = "0-0000-00000-00-0";
            mtbIDcard.Name = "mtbIDcard";
            mtbIDcard.Size = new Size(136, 23);
            mtbIDcard.TabIndex = 40;
            // 
            // tbnamelastname
            // 
            tbnamelastname.Location = new Point(370, 62);
            tbnamelastname.Name = "tbnamelastname";
            tbnamelastname.Size = new Size(184, 23);
            tbnamelastname.TabIndex = 39;
            tbnamelastname.KeyPress += tbnamelastname_KeyPress_1;
            // 
            // RdoGeneral
            // 
            RdoGeneral.AutoSize = true;
            RdoGeneral.Location = new Point(396, 177);
            RdoGeneral.Name = "RdoGeneral";
            RdoGeneral.Size = new Size(74, 19);
            RdoGeneral.TabIndex = 33;
            RdoGeneral.Text = "บุคคลทั่วไป";
            RdoGeneral.UseVisualStyleBackColor = true;
            // 
            // RdoStd
            // 
            RdoStd.AutoSize = true;
            RdoStd.Location = new Point(396, 140);
            RdoStd.Name = "RdoStd";
            RdoStd.Size = new Size(105, 19);
            RdoStd.TabIndex = 32;
            RdoStd.Text = "นักเรียน/นักศึกษา";
            RdoStd.UseVisualStyleBackColor = true;
            // 
            // RdoMember
            // 
            RdoMember.AutoSize = true;
            RdoMember.Checked = true;
            RdoMember.Location = new Point(396, 100);
            RdoMember.Name = "RdoMember";
            RdoMember.Size = new Size(57, 19);
            RdoMember.TabIndex = 31;
            RdoMember.TabStop = true;
            RdoMember.Text = "สมาชิก";
            RdoMember.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(287, 100);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 30;
            label3.Text = "ประเภทผู้ใช้บริการ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Black;
            label18.Location = new Point(287, 65);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 29;
            label18.Text = "ชื่อ-สกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(287, 29);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 14;
            label2.Text = "รหัสบัตรประจำตัวประชาชน";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(33, 53);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 29);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 12;
            label4.Text = "วันที่ใช้บริการ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbUnit);
            groupBox2.Controls.Add(CbbTypeUse);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 326);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 166);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ข้อมูลการใช้บริการ";
            // 
            // tbUnit
            // 
            tbUnit.Location = new Point(135, 78);
            tbUnit.Name = "tbUnit";
            tbUnit.Size = new Size(100, 23);
            tbUnit.TabIndex = 38;
            tbUnit.KeyPress += tbUnit_KeyPress;
            // 
            // CbbTypeUse
            // 
            CbbTypeUse.FormattingEnabled = true;
            CbbTypeUse.Items.AddRange(new object[] { "เล่น Internet 15 บาท/ชั่วโมง", "เล่น Game 10 บาท/ชั่วโมง", "ทำงานใช้โปรแกรม Microsoft Office 5 บาท/ชั่วโม" });
            CbbTypeUse.Location = new Point(135, 33);
            CbbTypeUse.Name = "CbbTypeUse";
            CbbTypeUse.Size = new Size(185, 23);
            CbbTypeUse.TabIndex = 37;
            CbbTypeUse.KeyPress += CbbTypeUse_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(286, 81);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 36;
            label7.Text = "ชั่วโมง";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(33, 81);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 35;
            label6.Text = "จำนวนการใช้บริการ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(33, 36);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 34;
            label5.Text = "ประเภทการใช้บริการ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(lblTotalPay);
            groupBox3.Controls.Add(lblTypeuser);
            groupBox3.Controls.Add(lblnamelastname);
            groupBox3.Controls.Add(lblIDcard);
            groupBox3.Controls.Add(lblDatetime);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(643, 74);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(377, 418);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Azuresol_Sketchy_Internet_256;
            pictureBox1.Location = new Point(142, 252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // lblTotalPay
            // 
            lblTotalPay.BackColor = Color.Cyan;
            lblTotalPay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPay.ForeColor = Color.FromArgb(192, 0, 0);
            lblTotalPay.Location = new Point(52, 356);
            lblTotalPay.Name = "lblTotalPay";
            lblTotalPay.Size = new Size(316, 37);
            lblTotalPay.TabIndex = 60;
            lblTotalPay.Text = "00.00";
            lblTotalPay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTypeuser
            // 
            lblTypeuser.BackColor = Color.Cyan;
            lblTypeuser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypeuser.ForeColor = Color.FromArgb(192, 0, 0);
            lblTypeuser.Location = new Point(142, 213);
            lblTypeuser.Name = "lblTypeuser";
            lblTypeuser.Size = new Size(205, 20);
            lblTypeuser.TabIndex = 59;
            lblTypeuser.Text = "-";
            lblTypeuser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblnamelastname
            // 
            lblnamelastname.BackColor = Color.Cyan;
            lblnamelastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnamelastname.ForeColor = Color.FromArgb(192, 0, 0);
            lblnamelastname.Location = new Point(142, 167);
            lblnamelastname.Name = "lblnamelastname";
            lblnamelastname.Size = new Size(205, 20);
            lblnamelastname.TabIndex = 58;
            lblnamelastname.Text = "-";
            lblnamelastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIDcard
            // 
            lblIDcard.BackColor = Color.Cyan;
            lblIDcard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDcard.ForeColor = Color.FromArgb(192, 0, 0);
            lblIDcard.Location = new Point(142, 121);
            lblIDcard.Name = "lblIDcard";
            lblIDcard.Size = new Size(205, 20);
            lblIDcard.TabIndex = 57;
            lblIDcard.Text = "-";
            lblIDcard.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDatetime
            // 
            lblDatetime.BackColor = Color.Cyan;
            lblDatetime.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatetime.ForeColor = Color.FromArgb(192, 0, 0);
            lblDatetime.Location = new Point(142, 81);
            lblDatetime.Name = "lblDatetime";
            lblDatetime.Size = new Size(205, 20);
            lblDatetime.TabIndex = 56;
            lblDatetime.Text = "-";
            lblDatetime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(52, 213);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 43;
            label12.Text = "ประเภทผู้ใช้บริการ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(96, 167);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 41;
            label11.Text = "ชื่อ-สกุล";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(69, 81);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 42;
            label10.Text = "วันที่ใช้บริการ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(15, 121);
            label9.Name = "label9";
            label9.Size = new Size(125, 15);
            label9.TabIndex = 41;
            label9.Text = "รหัสบัตรประจำตัวประชาชน";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 26);
            label8.Name = "label8";
            label8.Size = new Size(326, 43);
            label8.TabIndex = 8;
            label8.Text = "ข้อมูลการชำระเงิน";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btReNew
            // 
            btReNew.Location = new Point(413, 334);
            btReNew.Name = "btReNew";
            btReNew.Size = new Size(189, 48);
            btReNew.TabIndex = 5;
            btReNew.Text = "เริ่มใหม่";
            btReNew.UseVisualStyleBackColor = true;
            btReNew.Click += btReNew_Click;
            // 
            // btCalculator
            // 
            btCalculator.Location = new Point(413, 388);
            btCalculator.Name = "btCalculator";
            btCalculator.Size = new Size(189, 48);
            btCalculator.TabIndex = 6;
            btCalculator.Text = "คำนวณ";
            btCalculator.UseVisualStyleBackColor = true;
            btCalculator.Click += btCalculator_Click;
            // 
            // btEndProgram
            // 
            btEndProgram.Location = new Point(413, 444);
            btEndProgram.Name = "btEndProgram";
            btEndProgram.Size = new Size(189, 48);
            btEndProgram.TabIndex = 7;
            btEndProgram.Text = "จบโปรแกรม";
            btEndProgram.UseVisualStyleBackColor = true;
            btEndProgram.Click += btEndProgram_Click;
            // 
            // FrmInternetCafe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 525);
            Controls.Add(btEndProgram);
            Controls.Add(btCalculator);
            Controls.Add(btReNew);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.MenuHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInternetCafe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "โปรแกรม Internet Cafe";
            Load += FrmInternetCafe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private Label label2;
        private Label label18;
        private Label label3;
        private RadioButton RdoGeneral;
        private RadioButton RdoStd;
        private RadioButton RdoMember;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox CbbTypeUse;
        private TextBox tbnamelastname;
        private TextBox tbUnit;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btReNew;
        private Button btCalculator;
        private Button btEndProgram;
        private Label lblTypeuser;
        private Label lblnamelastname;
        private Label lblIDcard;
        private Label lblDatetime;
        private PictureBox pictureBox1;
        private Label lblTotalPay;
        private MaskedTextBox mtbIDcard;
    }
}