using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp;

namespace KSU_Fall_2023_Hackathon
{
    public partial class WetherInfoForm : Form
    {
        public WetherInfoForm()
        {
            InitializeComponent();
        }

        private void WetherInfoForm_Load(object sender, EventArgs e)
        {
            WeatherData weatherData = new WeatherData("Atlanta");
            weatherData.CheckWeather();

            CurrentTempLabel.Text = "Current Temputure: " + weatherData.Temp;
            MaxTemputureButton.Text = "Maximum Temputure: " + weatherData.TempMax;
            MinTempButton.Text = "Minumum Temputure: " + weatherData.TempMin;
            precipitationLabel.Text = "precipitation: " + weatherData.Precipitation;
        }
    }
}
