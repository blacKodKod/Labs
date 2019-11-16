namespace oop_lab11
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
            this.pictureBoxCloud = new System.Windows.Forms.PictureBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelWindDirection = new System.Windows.Forms.Label();
            this.labelWet = new System.Windows.Forms.Label();
            this.labelWaterTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.Label();
            this.txtWind = new System.Windows.Forms.Label();
            this.txtWindDirection = new System.Windows.Forms.Label();
            this.txtWet = new System.Windows.Forms.Label();
            this.txtWaterTemp = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.txtCloud = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Погода у Житомирі";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxCloud
            // 
            this.pictureBoxCloud.AccessibleDescription = "";
            this.pictureBoxCloud.AccessibleName = "";
            this.pictureBoxCloud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCloud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCloud.ImageLocation = "";
            this.pictureBoxCloud.Location = new System.Drawing.Point(134, 88);
            this.pictureBoxCloud.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCloud.Name = "pictureBoxCloud";
            this.pictureBoxCloud.Size = new System.Drawing.Size(63, 55);
            this.pictureBoxCloud.TabIndex = 1;
            this.pictureBoxCloud.TabStop = false;
            this.pictureBoxCloud.Tag = "";
            // 
            // labelTemp
            // 
            this.labelTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTemp.Location = new System.Drawing.Point(90, 169);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(199, 32);
            this.labelTemp.TabIndex = 2;
            this.labelTemp.Text = "Температура:";
            // 
            // labelWind
            // 
            this.labelWind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWind.AutoSize = true;
            this.labelWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWind.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelWind.Location = new System.Drawing.Point(170, 210);
            this.labelWind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(94, 32);
            this.labelWind.TabIndex = 3;
            this.labelWind.Text = "Вітер:";
            // 
            // labelWindDirection
            // 
            this.labelWindDirection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWindDirection.AutoSize = true;
            this.labelWindDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindDirection.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelWindDirection.Location = new System.Drawing.Point(91, 251);
            this.labelWindDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWindDirection.Name = "labelWindDirection";
            this.labelWindDirection.Size = new System.Drawing.Size(198, 32);
            this.labelWindDirection.TabIndex = 4;
            this.labelWindDirection.Text = "Напрям вітру:";
            // 
            // labelWet
            // 
            this.labelWet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWet.AutoSize = true;
            this.labelWet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWet.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelWet.Location = new System.Drawing.Point(128, 295);
            this.labelWet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWet.Name = "labelWet";
            this.labelWet.Size = new System.Drawing.Size(150, 32);
            this.labelWet.TabIndex = 5;
            this.labelWet.Text = "Вологість:";
            // 
            // labelWaterTemp
            // 
            this.labelWaterTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWaterTemp.AutoSize = true;
            this.labelWaterTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWaterTemp.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelWaterTemp.Location = new System.Drawing.Point(39, 337);
            this.labelWaterTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWaterTemp.Name = "labelWaterTemp";
            this.labelWaterTemp.Size = new System.Drawing.Size(269, 32);
            this.labelWaterTemp.TabIndex = 6;
            this.labelWaterTemp.Text = "Температура води:";
            // 
            // txtTemp
            // 
            this.txtTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTemp.AutoSize = true;
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTemp.Location = new System.Drawing.Point(316, 169);
            this.txtTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(23, 32);
            this.txtTemp.TabIndex = 7;
            this.txtTemp.Text = " ";
            // 
            // txtWind
            // 
            this.txtWind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWind.AutoSize = true;
            this.txtWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWind.Location = new System.Drawing.Point(316, 210);
            this.txtWind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(23, 32);
            this.txtWind.TabIndex = 8;
            this.txtWind.Text = " ";
            // 
            // txtWindDirection
            // 
            this.txtWindDirection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWindDirection.AutoSize = true;
            this.txtWindDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWindDirection.Location = new System.Drawing.Point(316, 251);
            this.txtWindDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWindDirection.Name = "txtWindDirection";
            this.txtWindDirection.Size = new System.Drawing.Size(23, 32);
            this.txtWindDirection.TabIndex = 9;
            this.txtWindDirection.Text = " ";
            // 
            // txtWet
            // 
            this.txtWet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWet.AutoSize = true;
            this.txtWet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWet.Location = new System.Drawing.Point(316, 295);
            this.txtWet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWet.Name = "txtWet";
            this.txtWet.Size = new System.Drawing.Size(23, 32);
            this.txtWet.TabIndex = 10;
            this.txtWet.Text = " ";
            // 
            // txtWaterTemp
            // 
            this.txtWaterTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWaterTemp.AutoSize = true;
            this.txtWaterTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWaterTemp.Location = new System.Drawing.Point(316, 337);
            this.txtWaterTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWaterTemp.Name = "txtWaterTemp";
            this.txtWaterTemp.Size = new System.Drawing.Size(23, 32);
            this.txtWaterTemp.TabIndex = 11;
            this.txtWaterTemp.Text = " ";
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReload.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonReload.Location = new System.Drawing.Point(112, 413);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(230, 65);
            this.buttonReload.TabIndex = 12;
            this.buttonReload.Text = "Оновити";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // txtCloud
            // 
            this.txtCloud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCloud.AutoSize = true;
            this.txtCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCloud.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtCloud.Location = new System.Drawing.Point(213, 99);
            this.txtCloud.Name = "txtCloud";
            this.txtCloud.Size = new System.Drawing.Size(23, 32);
            this.txtCloud.TabIndex = 13;
            this.txtCloud.Text = " ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(261, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Харипончук М.М., ПІ-60";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(472, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCloud);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.txtWaterTemp);
            this.Controls.Add(this.txtWet);
            this.Controls.Add(this.txtWindDirection);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.labelWaterTemp);
            this.Controls.Add(this.labelWet);
            this.Controls.Add(this.labelWindDirection);
            this.Controls.Add(this.labelWind);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.pictureBoxCloud);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(420, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Погода у Житомирі";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCloud;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label labelWindDirection;
        private System.Windows.Forms.Label labelWet;
        private System.Windows.Forms.Label labelWaterTemp;
        private System.Windows.Forms.Label txtTemp;
        private System.Windows.Forms.Label txtWind;
        private System.Windows.Forms.Label txtWindDirection;
        private System.Windows.Forms.Label txtWet;
        private System.Windows.Forms.Label txtWaterTemp;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label txtCloud;
        private System.Windows.Forms.Label label2;
    }
}

