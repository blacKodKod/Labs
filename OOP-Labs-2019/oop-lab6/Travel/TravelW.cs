using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
	public partial class TravelW : Form
	{
		public TravelW()
		{
			InitializeComponent();
		}

		private void TravelW_Load(object sender, EventArgs e)
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
			int k, gid;
			decimal emount;
			if (radioButtonSummer.Checked == true)
				if (comboBoxMaterial.SelectedIndex == 0)
					k = 100;
				else
					if (comboBoxMaterial.SelectedIndex == 1)
					k = 160;
				else
				if (comboBoxMaterial.SelectedIndex == 2)
					k = 120;
				else
					k = 20;
			else
				if (comboBoxMaterial.SelectedIndex == 0)
				k = 150;
			else
						if (comboBoxMaterial.SelectedIndex == 1)
				k = 200;
			else
			if (comboBoxMaterial.SelectedIndex == 2)
				k = 180;
			else
				k = 30;
			emount = numericUpDownDay.Value;
			if (checkBoxGid.Checked == true)
				gid = 50;
			else
				gid = 0;
			labelSum.Text = (k * emount + gid).ToString("F0");
			labelSum.Visible = true;
		}
	}
}
