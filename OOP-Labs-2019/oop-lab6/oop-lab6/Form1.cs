using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBoxMaterial.SelectedIndex = 0;
			System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
						System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
			customCulture.NumberFormat.NumberDecimalSeparator = ".";
			System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

		}

		private void buttonCalc_Click(object sender, EventArgs e)
		{
			labelSum.Text = "";
			double k, width, height, windowsill;
			bool ok, ok1 = false;
			if (checkBoxWindowsill.Checked == true)
				windowsill = 35;
			else
				windowsill = 0;

			if (radioButtonOneC.Checked == true)
				if (comboBoxMaterial.SelectedIndex == 0)
					k = 0.25;
				else
					if (comboBoxMaterial.SelectedIndex == 1)
						k = 0.05;
				else
					k = 0.15;
			else
				if (comboBoxMaterial.SelectedIndex == 0)
					k = 0.3;
				else
					if (comboBoxMaterial.SelectedIndex == 1)
						k = 0.1;
					else
						k = 0.2;

			ok = double.TryParse(textBoxWidth.Text, out width);
			if (!ok)
			{
				labelError.Visible = true;
				textBoxWidth.ForeColor = Color.Red;
			}
			else
				textBoxWidth.ForeColor = Color.Black;

			ok1 = double.TryParse(textBoxHeight.Text, out height);
			if (!ok1)
			{
				labelError.Visible = true;
				textBoxHeight.ForeColor = Color.Red;
			}
			else
				textBoxHeight.ForeColor = Color.Black;

			if (ok && ok1)
			{
				labelError.Visible = false;
				labelSum.Text = (width * height * k + windowsill).ToString("F2");
			}
				
		}
	}
}
