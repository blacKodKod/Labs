namespace Travel
{
	partial class TravelW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelW));
            this.labelSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.checkBoxGid = new System.Windows.Forms.CheckBox();
            this.radioButtonSummer = new System.Windows.Forms.RadioButton();
            this.radioButtonWinter = new System.Windows.Forms.RadioButton();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelSum.ForeColor = System.Drawing.Color.Brown;
            this.labelSum.Location = new System.Drawing.Point(206, 197);
            this.labelSum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(53, 33);
            this.labelSum.TabIndex = 29;
            this.labelSum.Text = "0.0";
            this.labelSum.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(63, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 33);
            this.label7.TabIndex = 28;
            this.label7.Text = "Вартість:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonCalc.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonCalc.Location = new System.Drawing.Point(69, 114);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(205, 63);
            this.buttonCalc.TabIndex = 27;
            this.buttonCalc.Text = "Розрахувати";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // checkBoxGid
            // 
            this.checkBoxGid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxGid.AutoSize = true;
            this.checkBoxGid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGid.Location = new System.Drawing.Point(343, 152);
            this.checkBoxGid.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxGid.Name = "checkBoxGid";
            this.checkBoxGid.Size = new System.Drawing.Size(120, 25);
            this.checkBoxGid.TabIndex = 26;
            this.checkBoxGid.Text = "Власний гід";
            this.checkBoxGid.UseVisualStyleBackColor = true;
            // 
            // radioButtonSummer
            // 
            this.radioButtonSummer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSummer.AutoSize = true;
            this.radioButtonSummer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSummer.Location = new System.Drawing.Point(343, 105);
            this.radioButtonSummer.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonSummer.Name = "radioButtonSummer";
            this.radioButtonSummer.Size = new System.Drawing.Size(58, 25);
            this.radioButtonSummer.TabIndex = 25;
            this.radioButtonSummer.Text = "Літо";
            this.radioButtonSummer.UseVisualStyleBackColor = true;
            // 
            // radioButtonWinter
            // 
            this.radioButtonWinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonWinter.AutoSize = true;
            this.radioButtonWinter.Checked = true;
            this.radioButtonWinter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWinter.Location = new System.Drawing.Point(343, 64);
            this.radioButtonWinter.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonWinter.Name = "radioButtonWinter";
            this.radioButtonWinter.Size = new System.Drawing.Size(72, 25);
            this.radioButtonWinter.TabIndex = 24;
            this.radioButtonWinter.TabStop = true;
            this.radioButtonWinter.Text = "Зима";
            this.radioButtonWinter.UseVisualStyleBackColor = true;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Болгарія",
            "Німеччина",
            "Польща",
            "Египет"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(108, 25);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(166, 21);
            this.comboBoxMaterial.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Країна:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.Location = new System.Drawing.Point(19, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Час подорожі (днів)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(339, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Сезон";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.Location = new System.Drawing.Point(308, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Харипончук М.М.,гр.ПІ-60";
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.BackColor = System.Drawing.Color.LightCyan;
            this.numericUpDownDay.Location = new System.Drawing.Point(217, 68);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownDay.TabIndex = 31;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TravelW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.checkBoxGid);
            this.Controls.Add(this.radioButtonSummer);
            this.Controls.Add(this.radioButtonWinter);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(540, 341);
            this.MinimumSize = new System.Drawing.Size(450, 284);
            this.Name = "TravelW";
            this.Text = "Лабораторна робота №6";
            this.Load += new System.EventHandler(this.TravelW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSum;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonCalc;
		private System.Windows.Forms.CheckBox checkBoxGid;
		private System.Windows.Forms.RadioButton radioButtonSummer;
		private System.Windows.Forms.RadioButton radioButtonWinter;
		private System.Windows.Forms.ComboBox comboBoxMaterial;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownDay;
	}
}

