using System;

namespace shapi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        public string IsAlive { get; set; } = "Çok Şükür!!";
        public string IsAlive2 { get; set; } = "Çok Şükür!!";

    }
}
