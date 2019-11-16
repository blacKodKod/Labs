using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class Weather
    {
        public string URL { get; private set; }
        public string Cloudiness { get; private set; }
        public string Temperature { get; private set; }
        public string Wind { get; private set; }
        public string WindDirection { get; private set; }
        public string Wet { get; private set; }
        public string WaterTemperature { get; private set; }
        public string Picture { get; private set; }
        
        Regex tempRegex = new Regex("class='value m_temp c'>(([+-]\\d+)|0)<span class=\"meas\">&deg;C");
        Regex windRegex = new Regex("class='value m_wind ms' style='display:inline'>(\\d+)<span class=\"unit\">м/с");
        Regex windDirectionRegex = new Regex("<dt>(\\w+)");
        Regex wetRegex = new Regex("class=\"wicon hum\" title=\"Вологість\">(\\d+)<span class=\"unit\">%<span class=\"meas_hum_txt hidden\">&nbsp;волог.");
        Regex waterTempRegex = new Regex("class=\"value m_temp c\">(\\d+)<span class=\"meas unit\">&deg;C<\\/span><span class=\"unit\">вода");
        Regex cloudniessRegex = new Regex("<dd><table><tr><td>([А-Яа-яії]+[, ]*[А-Яа-яії]+)+<\\/td><\\/tr><\\/table><\\/dd>");
        Regex picture = new Regex("style=\"background-image: url\\((.+)\\)\"><br \\/><\\/dt>");

        public void GetInfoAboutWeather()
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            string htmlCode = client.DownloadString(URL);

            Temperature = tempRegex.Match(htmlCode).Groups[1].Value;
            Wind = windRegex.Match(htmlCode).Groups[1].Value;
            WindDirection = windDirectionRegex.Match(htmlCode).Groups[1].Value;
            Wet = wetRegex.Match(htmlCode).Groups[1].Value;
            WaterTemperature = waterTempRegex.Match(htmlCode).Groups[1].Value;
            Cloudiness = cloudniessRegex.Match(htmlCode).Groups[1].Value;
            Picture = picture.Match(htmlCode).Groups[1].Value;
        }

        public Weather(string URL)
        {
            this.URL = URL;
        }
    }
}
