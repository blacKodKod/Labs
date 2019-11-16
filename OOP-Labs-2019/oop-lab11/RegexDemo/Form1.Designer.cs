namespace RegexDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxUkrName = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStatusPhone = new System.Windows.Forms.Label();
            this.labelStatusPassport = new System.Windows.Forms.Label();
            this.labelStatusNumber = new System.Windows.Forms.Label();
            this.labelStatusUkrName = new System.Windows.Forms.Label();
            this.labelStatusTime = new System.Windows.Forms.Label();
            this.labelStatusEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Демонстрація роботи з регулярними виразами";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(48, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер телефону:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(53, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер паспорта:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 79);
            this.label4.TabIndex = 3;
            this.label4.Text = "Число з інтервалу [10311;89645]:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(68, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Українське ім\'я:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(111, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Введіть час:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(175, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "E-mail:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(269, 116);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(252, 28);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassport.Location = new System.Drawing.Point(269, 163);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(252, 28);
            this.textBoxPassport.TabIndex = 9;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(269, 223);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(252, 28);
            this.textBoxNumber.TabIndex = 10;
            // 
            // textBoxUkrName
            // 
            this.textBoxUkrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUkrName.Location = new System.Drawing.Point(269, 286);
            this.textBoxUkrName.Name = "textBoxUkrName";
            this.textBoxUkrName.Size = new System.Drawing.Size(252, 28);
            this.textBoxUkrName.TabIndex = 11;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime.Location = new System.Drawing.Point(269, 332);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(252, 28);
            this.textBoxTime.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(269, 376);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(252, 28);
            this.textBoxEmail.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(256, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "Перевірити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(539, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Харипончук М.М., ПІ-60";
            // 
            // labelStatusPhone
            // 
            this.labelStatusPhone.AutoSize = true;
            this.labelStatusPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusPhone.Location = new System.Drawing.Point(527, 114);
            this.labelStatusPhone.Name = "labelStatusPhone";
            this.labelStatusPhone.Size = new System.Drawing.Size(15, 24);
            this.labelStatusPhone.TabIndex = 16;
            this.labelStatusPhone.Text = " ";
            // 
            // labelStatusPassport
            // 
            this.labelStatusPassport.AutoSize = true;
            this.labelStatusPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusPassport.Location = new System.Drawing.Point(527, 161);
            this.labelStatusPassport.Name = "labelStatusPassport";
            this.labelStatusPassport.Size = new System.Drawing.Size(15, 24);
            this.labelStatusPassport.TabIndex = 17;
            this.labelStatusPassport.Text = " ";
            // 
            // labelStatusNumber
            // 
            this.labelStatusNumber.AutoSize = true;
            this.labelStatusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusNumber.Location = new System.Drawing.Point(527, 221);
            this.labelStatusNumber.Name = "labelStatusNumber";
            this.labelStatusNumber.Size = new System.Drawing.Size(15, 24);
            this.labelStatusNumber.TabIndex = 18;
            this.labelStatusNumber.Text = " ";
            // 
            // labelStatusUkrName
            // 
            this.labelStatusUkrName.AutoSize = true;
            this.labelStatusUkrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusUkrName.Location = new System.Drawing.Point(527, 284);
            this.labelStatusUkrName.Name = "labelStatusUkrName";
            this.labelStatusUkrName.Size = new System.Drawing.Size(15, 24);
            this.labelStatusUkrName.TabIndex = 19;
            this.labelStatusUkrName.Text = " ";
            // 
            // labelStatusTime
            // 
            this.labelStatusTime.AutoSize = true;
            this.labelStatusTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusTime.Location = new System.Drawing.Point(527, 330);
            this.labelStatusTime.Name = "labelStatusTime";
            this.labelStatusTime.Size = new System.Drawing.Size(15, 24);
            this.labelStatusTime.TabIndex = 20;
            this.labelStatusTime.Text = " ";
            // 
            // labelStatusEmail
            // 
            this.labelStatusEmail.AutoSize = true;
            this.labelStatusEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusEmail.Location = new System.Drawing.Point(527, 374);
            this.labelStatusEmail.Name = "labelStatusEmail";
            this.labelStatusEmail.Size = new System.Drawing.Size(15, 24);
            this.labelStatusEmail.TabIndex = 21;
            this.labelStatusEmail.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(750, 490);
            this.Controls.Add(this.labelStatusEmail);
            this.Controls.Add(this.labelStatusTime);
            this.Controls.Add(this.labelStatusUkrName);
            this.Controls.Add(this.labelStatusNumber);
            this.Controls.Add(this.labelStatusPassport);
            this.Controls.Add(this.labelStatusPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxUkrName);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Демонстрація роботи з регулярними виразами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxUkrName;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStatusPhone;
        private System.Windows.Forms.Label labelStatusPassport;
        private System.Windows.Forms.Label labelStatusNumber;
        private System.Windows.Forms.Label labelStatusUkrName;
        private System.Windows.Forms.Label labelStatusTime;
        private System.Windows.Forms.Label labelStatusEmail;
    }
}

