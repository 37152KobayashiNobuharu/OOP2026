namespace Section01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dtpDate = new DateTimePicker();
            btGet = new Button();
            tbOut = new TextBox();
            nudDay = new NumericUpDown();
            label1 = new Label();
            dtpBirth = new DateTimePicker();
            btBirthCalc = new Button();
            tbOut1 = new TextBox();
            label2 = new Label();
            tbOut2 = new TextBox();
            tbOut3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            メモ = new Label();
            tbOut4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(12, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 0;
            // 
            // btGet
            // 
            btGet.Location = new Point(272, 12);
            btGet.Name = "btGet";
            btGet.Size = new Size(98, 39);
            btGet.TabIndex = 1;
            btGet.Text = "計算";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(12, 191);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(464, 39);
            tbOut.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(101, 91);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(82, 39);
            nudDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(189, 98);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dtpBirth
            // 
            dtpBirth.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirth.Location = new Point(12, 321);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 39);
            dtpBirth.TabIndex = 0;
            // 
            // btBirthCalc
            // 
            btBirthCalc.BackColor = SystemColors.ButtonHighlight;
            btBirthCalc.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btBirthCalc.Location = new Point(233, 321);
            btBirthCalc.Name = "btBirthCalc";
            btBirthCalc.Size = new Size(75, 39);
            btBirthCalc.TabIndex = 5;
            btBirthCalc.Text = "計算";
            btBirthCalc.UseVisualStyleBackColor = false;
            btBirthCalc.Click += btBirthCalc_Click;
            // 
            // tbOut1
            // 
            tbOut1.Location = new Point(85, 402);
            tbOut1.Name = "tbOut1";
            tbOut1.Size = new Size(448, 23);
            tbOut1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 305);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "生年月日";
            // 
            // tbOut2
            // 
            tbOut2.Location = new Point(85, 450);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(467, 23);
            tbOut2.TabIndex = 8;
            // 
            // tbOut3
            // 
            tbOut3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut3.Location = new Point(85, 491);
            tbOut3.Multiline = true;
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(467, 51);
            tbOut3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 499);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 9;
            label3.Text = "メモ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 458);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "経過日数";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 410);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "年齢";
            // 
            // メモ
            // 
            メモ.AutoSize = true;
            メモ.Location = new Point(41, 551);
            メモ.Name = "メモ";
            メモ.Size = new Size(38, 15);
            メモ.TabIndex = 10;
            メモ.Text = "label6";
            // 
            // tbOut4
            // 
            tbOut4.Location = new Point(85, 548);
            tbOut4.Multiline = true;
            tbOut4.Name = "tbOut4";
            tbOut4.Size = new Size(467, 71);
            tbOut4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 644);
            Controls.Add(tbOut4);
            Controls.Add(メモ);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(label2);
            Controls.Add(tbOut1);
            Controls.Add(btBirthCalc);
            Controls.Add(label1);
            Controls.Add(nudDay);
            Controls.Add(tbOut);
            Controls.Add(btGet);
            Controls.Add(dtpBirth);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "開く";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btGet;
        private TextBox tbOut;
        private NumericUpDown nudDay;
        private Label label1;
        private DateTimePicker dtpBirth;
        private Button btBirthCalc;
        private TextBox tbOut1;
        private Label label2;
        private TextBox tbOut2;
        private TextBox tbOut3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label メモ;
        private TextBox tbOut4;
    }
}
