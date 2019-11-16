using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace oop_lab11
{
    public partial class Form1 : Form
    {
        Weather weather;

        public Form1()
        {
            InitializeComponent();
            weather = new Weather("https://www.gismeteo.ua/ua/weather-zhytomyr-4943/");
            buttonReload_Click(this, new EventArgs());
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            weather.GetInfoAboutWeather();
            txtCloud.Text = weather.Cloudiness;
            txtTemp.Text = weather.Temperature + " °C";
            txtWind.Text = weather.Wind + " м/с";
            txtWindDirection.Text = weather.WindDirection;
            txtWet.Text = weather.Wet + " %";
            txtWaterTemp.Text = weather.WaterTemperature + " °C";
            pictureBoxCloud.ImageLocation = "http:";
            pictureBoxCloud.ImageLocation += weather.Picture;
        }
    }
}
