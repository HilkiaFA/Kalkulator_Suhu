namespace suhu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_suhu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_konversi = new System.Windows.Forms.TextBox();
            this.box_suhu = new System.Windows.Forms.ComboBox();
            this.box_konversi = new System.Windows.Forms.ComboBox();
            this.lbl_suhu = new System.Windows.Forms.Label();
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_input2 = new System.Windows.Forms.Label();
            this.btn_konversi = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_suhuderajat = new System.Windows.Forms.Label();
            this.lbl_derajat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Voice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suhu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.label2.Location = new System.Drawing.Point(32, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasil";
            // 
            // txt_suhu
            // 
            this.txt_suhu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_suhu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_suhu.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suhu.Location = new System.Drawing.Point(32, 276);
            this.txt_suhu.Multiline = true;
            this.txt_suhu.Name = "txt_suhu";
            this.txt_suhu.Size = new System.Drawing.Size(448, 50);
            this.txt_suhu.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 49);
            this.label3.TabIndex = 12;
            this.label3.Text = "KONVERSI SUHU";
            // 
            // txt_konversi
            // 
            this.txt_konversi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_konversi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_konversi.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_konversi.Location = new System.Drawing.Point(33, 413);
            this.txt_konversi.Multiline = true;
            this.txt_konversi.Name = "txt_konversi";
            this.txt_konversi.Size = new System.Drawing.Size(448, 50);
            this.txt_konversi.TabIndex = 13;
            // 
            // box_suhu
            // 
            this.box_suhu.AccessibleDescription = "";
            this.box_suhu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_suhu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box_suhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_suhu.FormattingEnabled = true;
            this.box_suhu.IntegralHeight = false;
            this.box_suhu.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Rankine",
            "Reamur"});
            this.box_suhu.Location = new System.Drawing.Point(21, 152);
            this.box_suhu.Name = "box_suhu";
            this.box_suhu.Size = new System.Drawing.Size(215, 39);
            this.box_suhu.TabIndex = 14;
            this.box_suhu.SelectedIndexChanged += new System.EventHandler(this.box_suhu_SelectedIndexChanged);
            // 
            // box_konversi
            // 
            this.box_konversi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.box_konversi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_konversi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box_konversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_konversi.FormattingEnabled = true;
            this.box_konversi.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Rankine",
            "Reamur"});
            this.box_konversi.Location = new System.Drawing.Point(288, 152);
            this.box_konversi.Name = "box_konversi";
            this.box_konversi.Size = new System.Drawing.Size(215, 39);
            this.box_konversi.TabIndex = 15;
            this.box_konversi.SelectedIndexChanged += new System.EventHandler(this.box_konversi_SelectedIndexChanged);
            // 
            // lbl_suhu
            // 
            this.lbl_suhu.AutoSize = true;
            this.lbl_suhu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_suhu.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suhu.ForeColor = System.Drawing.Color.Red;
            this.lbl_suhu.Location = new System.Drawing.Point(30, 333);
            this.lbl_suhu.Name = "lbl_suhu";
            this.lbl_suhu.Size = new System.Drawing.Size(41, 15);
            this.lbl_suhu.TabIndex = 18;
            this.lbl_suhu.Text = "label4";
            this.lbl_suhu.Visible = false;
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.BackColor = System.Drawing.Color.Transparent;
            this.lbl_input.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.ForeColor = System.Drawing.Color.Red;
            this.lbl_input.Location = new System.Drawing.Point(18, 194);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(41, 15);
            this.lbl_input.TabIndex = 19;
            this.lbl_input.Text = "label5";
            this.lbl_input.Visible = false;
            // 
            // lbl_input2
            // 
            this.lbl_input2.AutoSize = true;
            this.lbl_input2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_input2.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input2.ForeColor = System.Drawing.Color.Red;
            this.lbl_input2.Location = new System.Drawing.Point(284, 194);
            this.lbl_input2.Name = "lbl_input2";
            this.lbl_input2.Size = new System.Drawing.Size(41, 15);
            this.lbl_input2.TabIndex = 20;
            this.lbl_input2.Text = "label6";
            this.lbl_input2.Visible = false;
            // 
            // btn_konversi
            // 
            this.btn_konversi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_konversi.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_konversi.Location = new System.Drawing.Point(141, 532);
            this.btn_konversi.Name = "btn_konversi";
            this.btn_konversi.Size = new System.Drawing.Size(154, 43);
            this.btn_konversi.TabIndex = 16;
            this.btn_konversi.Text = "Convert";
            this.btn_konversi.UseVisualStyleBackColor = true;
            this.btn_konversi.Click += new System.EventHandler(this.btn_konversi_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold);
            this.btn_reset.Location = new System.Drawing.Point(333, 532);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(147, 43);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 91);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(-8, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 5);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(37, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 1);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(25, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 1);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(292, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 1);
            this.panel5.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(37, 461);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(432, 1);
            this.panel6.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = ">";
            // 
            // lbl_suhuderajat
            // 
            this.lbl_suhuderajat.AutoSize = true;
            this.lbl_suhuderajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suhuderajat.Location = new System.Drawing.Point(481, 291);
            this.lbl_suhuderajat.Name = "lbl_suhuderajat";
            this.lbl_suhuderajat.Size = new System.Drawing.Size(79, 29);
            this.lbl_suhuderajat.TabIndex = 28;
            this.lbl_suhuderajat.Text = "label5";
            this.lbl_suhuderajat.Visible = false;
            // 
            // lbl_derajat
            // 
            this.lbl_derajat.AutoSize = true;
            this.lbl_derajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_derajat.Location = new System.Drawing.Point(480, 423);
            this.lbl_derajat.Name = "lbl_derajat";
            this.lbl_derajat.Size = new System.Drawing.Size(79, 29);
            this.lbl_derajat.TabIndex = 29;
            this.lbl_derajat.Text = "label6";
            this.lbl_derajat.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Voice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Voice
            // 
            this.Voice.Location = new System.Drawing.Point(382, 469);
            this.Voice.Name = "Voice";
            this.Voice.Size = new System.Drawing.Size(75, 23);
            this.Voice.TabIndex = 31;
            this.Voice.Text = "Voice";
            this.Voice.UseVisualStyleBackColor = true;
            this.Voice.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "©Copyright Hilkia/Hanif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(540, 634);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Voice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_derajat);
            this.Controls.Add(this.lbl_suhuderajat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_input2);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.lbl_suhu);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_konversi);
            this.Controls.Add(this.box_konversi);
            this.Controls.Add(this.box_suhu);
            this.Controls.Add(this.txt_konversi);
            this.Controls.Add(this.txt_suhu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMK NEGERI 1 SAMPIT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_suhu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_konversi;
        private System.Windows.Forms.ComboBox box_suhu;
        private System.Windows.Forms.ComboBox box_konversi;
        private System.Windows.Forms.Label lbl_suhu;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Label lbl_input2;
        private System.Windows.Forms.Button btn_konversi;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_suhuderajat;
        private System.Windows.Forms.Label lbl_derajat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Voice;
        private System.Windows.Forms.Label label5;
    }
}

