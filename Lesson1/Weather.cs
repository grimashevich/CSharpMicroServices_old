using System;

namespace Lesson1
{
    public class Weather
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public Weather(int temp)
        {
            TemperatureC = temp;
            Date = DateTime.Now;

        }
        public Weather(int temp, string date)
        {
            DateTime curDate;

            TemperatureC = temp;
            if (!DateTime.TryParse(date, out curDate))
                curDate = DateTime.MinValue;
            Date = curDate;
        }

        public override string ToString()
        {
            return $"{Date.ToString("d")}\t{TemperatureC}°C";
        }
    }
}
