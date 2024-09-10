namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sumbtn = new Button();
            multiplrbtn = new Button();
            minusebtn = new Button();
            dividebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            number1 = new NumericUpDown();
            number2 = new NumericUpDown();
            personbtn = new Button();
            tavan = new Button();
            tava2btn = new Button();
            ((System.ComponentModel.ISupportInitialize)number1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number2).BeginInit();
            SuspendLayout();
            // 
            // sumbtn
            // 
            sumbtn.Location = new Point(12, 103);
            sumbtn.Name = "sumbtn";
            sumbtn.Size = new Size(123, 60);
            sumbtn.TabIndex = 0;
            sumbtn.Text = "+";
            sumbtn.UseVisualStyleBackColor = true;
            sumbtn.Click += sumbtn_Click;
            // 
            // multiplrbtn
            // 
            multiplrbtn.Location = new Point(12, 169);
            multiplrbtn.Name = "multiplrbtn";
            multiplrbtn.Size = new Size(123, 60);
            multiplrbtn.TabIndex = 1;
            multiplrbtn.Text = "*";
            multiplrbtn.UseVisualStyleBackColor = true;
            multiplrbtn.Click += multiplrbtn_Click;
            // 
            // minusebtn
            // 
            minusebtn.Location = new Point(141, 103);
            minusebtn.Name = "minusebtn";
            minusebtn.Size = new Size(123, 60);
            minusebtn.TabIndex = 2;
            minusebtn.Text = "-";
            minusebtn.UseVisualStyleBackColor = true;
            minusebtn.Click += minusebtn_Click;
            // 
            // dividebtn
            // 
            dividebtn.Location = new Point(141, 169);
            dividebtn.Name = "dividebtn";
            dividebtn.Size = new Size(123, 60);
            dividebtn.TabIndex = 3;
            dividebtn.Text = "/";
            dividebtn.UseVisualStyleBackColor = true;
            dividebtn.Click += dividebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "عدد اول";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 42);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "عدد دوم";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(12, 72);
            lblResult.Name = "lblResult";
            lblResult.RightToLeft = RightToLeft.Yes;
            lblResult.Size = new Size(207, 21);
            lblResult.TabIndex = 8;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // number1
            // 
            number1.Location = new Point(12, 7);
            number1.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            number1.Minimum = new decimal(new int[] { 1874919424, 2328306, 0, int.MinValue });
            number1.Name = "number1";
            number1.Size = new Size(207, 23);
            number1.TabIndex = 9;
            number1.TextAlign = HorizontalAlignment.Center;
            number1.UpDownAlign = LeftRightAlignment.Left;
            number1.UseWaitCursor = true;
            // 
            // number2
            // 
            number2.Location = new Point(12, 40);
            number2.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            number2.Minimum = new decimal(new int[] { 1874919424, 2328306, 0, int.MinValue });
            number2.Name = "number2";
            number2.Size = new Size(207, 23);
            number2.TabIndex = 10;
            number2.TextAlign = HorizontalAlignment.Center;
            number2.UpDownAlign = LeftRightAlignment.Left;
            // 
            // personbtn
            // 
            personbtn.Location = new Point(140, 235);
            personbtn.Name = "personbtn";
            personbtn.Size = new Size(123, 60);
            personbtn.TabIndex = 11;
            personbtn.Text = "%";
            personbtn.UseVisualStyleBackColor = true;
            personbtn.Click += personbtn_Click;
            // 
            // tavan
            // 
            tavan.Location = new Point(11, 235);
            tavan.Name = "tavan";
            tavan.Size = new Size(123, 60);
            tavan.TabIndex = 12;
            tavan.Text = "x^y";
            tavan.UseVisualStyleBackColor = true;
            tavan.Click += tavan_Click;
            // 
            // tava2btn
            // 
            tava2btn.Location = new Point(140, 301);
            tava2btn.Name = "tava2btn";
            tava2btn.Size = new Size(123, 60);
            tava2btn.TabIndex = 13;
            tava2btn.Text = "x^2";
            tava2btn.UseVisualStyleBackColor = true;
            tava2btn.Click += tava2btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 376);
            Controls.Add(tava2btn);
            Controls.Add(tavan);
            Controls.Add(personbtn);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dividebtn);
            Controls.Add(minusebtn);
            Controls.Add(multiplrbtn);
            Controls.Add(sumbtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)number1).EndInit();
            ((System.ComponentModel.ISupportInitialize)number2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sumbtn;
        private Button multiplrbtn;
        private Button minusebtn;
        private Button dividebtn;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private NumericUpDown number1;
        private NumericUpDown number2;
        private Button personbtn;
        private Button tavan;
        private Button tava2btn;
    }
}
