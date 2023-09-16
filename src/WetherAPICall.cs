using System.Net;
using System.Xml;

namespace WeatherApp
{
    class WeatherData
    {
        public WeatherData(string City)
        {
            city = City;
        }
        private string city;
        private float temp;
        private float tempMax;
        private float tempMin;
        private string precipitation;

        public void CheckWeather()
        {
            WeatherAPI DataAPI = new WeatherAPI(City);
            temp = DataAPI.GetTemp();
            tempMax = DataAPI.GetMaxTemp();
            tempMin = DataAPI.GetMinTemp();
            string x = DataAPI.GetPrecipitation();
            precipitation = char.ToUpper(x[0]) + x.Substring(1);

        }

        public string City { get => city; set => city = value; }
        public float Temp { get => temp; set => temp = value; }
        public float TempMax { get => tempMax; set => tempMax = value; }
        public float TempMin { get => tempMin; set => tempMin = value; }
        public string Precipitation { get => precipitation; set => precipitation = value; }
    }
    class WeatherAPI
    {
        public WeatherAPI(string city)
        {
            SetCurrentURL(city);
            xmlDocument = GetXML(CurrentURL);
        }

        public float GetTemp()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//temperature");
            XmlAttribute temp_value = temp_node.Attributes["value"];
            string temp_string = temp_value.Value;
            return float.Parse(temp_string);
        }

        public float GetMaxTemp()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//temperature");
            XmlAttribute temp_value = temp_node.Attributes["max"];
            string temp_string = temp_value.Value;
            return float.Parse(temp_string);
        }

        public float GetMinTemp()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//temperature");
            XmlAttribute temp_value = temp_node.Attributes["min"];
            string temp_string = temp_value.Value;
            return float.Parse(temp_string);
        }

        public string GetPrecipitation()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//precipitation");
            XmlAttribute temp_value = temp_node.Attributes["mode"];
            return temp_value.Value;
        }

        private const string APIKEY = "249abb4e61msh7bb466740cc3e2ap1328dbjsnea1986d71dde";
        private string CurrentURL;
        private XmlDocument xmlDocument;

        private void SetCurrentURL(string location)
        {
            CurrentURL = String.Format("http://api.openweathermap.org/data/2.5/weather?q=" + location + "&mode=xml&units=imperial&appid=78dff84492be32f8b4f77692904607a1");
        }

        private XmlDocument GetXML(string CurrentURL)
        {
            using (var webClient = new WebClient())
            {
                var xmlContent = webClient.DownloadString(CurrentURL);
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlContent);
                return xmlDocument;
            }
        }
    }
}