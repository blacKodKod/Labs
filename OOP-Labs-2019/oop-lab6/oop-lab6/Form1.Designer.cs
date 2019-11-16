namespace oop_lab6
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.radioButtonOneC = new System.Windows.Forms.RadioButton();
            this.radioButtonTwoC = new System.Windows.Forms.RadioButton();
            this.checkBoxWindowsill = new System.Windows.Forms.CheckBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(38, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Розміри вікна";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(496, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Склопакет";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxWidth.ForeColor = System.Drawing.Color.Black;
            this.textBoxWidth.Location = new System.Drawing.Point(181, 67);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(114, 32);
            this.textBoxWidth.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ширина (см):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Висота (см):";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxHeight.Location = new System.Drawing.Point(181, 106);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(114, 32);
            this.textBoxHeight.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(62, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Матеріал:";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.BackColor = System.Drawing.Color.LightBlue;
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.ForeColor = System.Drawing.Color.Navy;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Дерево",
            "Метал",
            "Металопластик"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(181, 151);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(224, 31);
            this.comboBoxMaterial.TabIndex = 8;
            // 
            // radioButtonOneC
            // 
            this.radioButtonOneC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonOneC.AutoSize = true;
            this.radioButtonOneC.Checked = true;
            this.radioButtonOneC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOneC.Location = new System.Drawing.Point(475, 66);
            this.radioButtonOneC.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonOneC.Name = "radioButtonOneC";
            this.radioButtonOneC.Size = new System.Drawing.Size(190, 27);
            this.radioButtonOneC.TabIndex = 9;
            this.radioButtonOneC.TabStop = true;
            this.radioButtonOneC.Text = "Однокамерний";
            this.radioButtonOneC.UseVisualStyleBackColor = true;
            // 
            // radioButtonTwoC
            // 
            this.radioButtonTwoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTwoC.AutoSize = true;
            this.radioButtonTwoC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTwoC.Location = new System.Drawing.Point(475, 105);
            this.radioButtonTwoC.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonTwoC.Name = "radioButtonTwoC";
            this.radioButtonTwoC.Size = new System.Drawing.Size(173, 27);
            this.radioButtonTwoC.TabIndex = 10;
            this.radioButtonTwoC.Text = "Двокамерний";
            this.radioButtonTwoC.UseVisualStyleBackColor = true;
            // 
            // checkBoxWindowsill
            // 
            this.checkBoxWindowsill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWindowsill.AutoSize = true;
            this.checkBoxWindowsill.Checked = true;
            this.checkBoxWindowsill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWindowsill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWindowsill.Location = new System.Drawing.Point(487, 155);
            this.checkBoxWindowsill.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxWindowsill.Name = "checkBoxWindowsill";
            this.checkBoxWindowsill.Size = new System.Drawing.Size(129, 27);
            this.checkBoxWindowsill.TabIndex = 11;
            this.checkBoxWindowsill.Text = "Підвіконня";
            this.checkBoxWindowsill.UseVisualStyleBackColor = true;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalc.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonCalc.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonCalc.Location = new System.Drawing.Point(449, 205);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(245, 63);
            this.buttonCalc.TabIndex = 12;
            this.buttonCalc.Text = "Розрахувати";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(25, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 40);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вартість:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.ForeColor = System.Drawing.Color.Brown;
            this.labelSum.Location = new System.Drawing.Point(209, 213);
            this.labelSum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 40);
            this.labelSum.TabIndex = 14;
            // 
            // labelAutor
            // 
            this.labelAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutor.Location = new System.Drawing.Point(471, 323);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(228, 21);
            this.labelAutor.TabIndex = 17;
            this.labelAutor.Text = "Харипончук М.М.,гр.ПІ-60";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.LightYellow;
            this.labelError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(237, 24);
            this.labelError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(202, 23);
            this.labelError.TabIndex = 18;
            this.labelError.Text = "Виправте помилки!";
            this.labelError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(713, 353);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.checkBoxWindowsill);
            this.Controls.Add(this.radioButtonTwoC);
            this.Controls.Add(this.radioButtonOneC);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(731, 405);
            this.MinimumSize = new System.Drawing.Size(632, 368);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лабораторна робота №6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxWidth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxHeight;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxMaterial;
		private System.Windows.Forms.RadioButton radioButtonOneC;
		private System.Windows.Forms.RadioButton radioButtonTwoC;
		private System.Windows.Forms.CheckBox checkBoxWindowsill;
		private System.Windows.Forms.Button buttonCalc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelError;
    }
}

