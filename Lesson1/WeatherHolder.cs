using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson1
{
    public class WeatherHolder
    {
        private List<Weather> _weatherList;

        public void AddWeather(Weather newWeather) => _weatherList.Add(newWeather);

        public WeatherHolder()
        {
            _weatherList = new List<Weather>();
        }


        public List<Weather> GetWeather(string startDate, string EndDate)
        {
            DateTime start, end;
            ParseDate(startDate, EndDate, out start, out end);
            List<Weather> result = _weatherList.Where(x => x.Date >= start && x.Date <= end).ToList();
            return result;
        }

        public List<Weather> GetWeather() => GetWeather("", "");

        public bool UpdateWeather(string date, int temp)
        {
            DateTime curDate;
            if (!DateTime.TryParse(date, out curDate))
                return false;
            foreach (Weather weather in _weatherList)
            {
                if (weather.Date == curDate)
                {
                    weather.TemperatureC = temp;
                    return true;
                }
            }
            return false;
        }

        public void DeleteWeather(string startDate, string EndDate)
        {
            DateTime start, end;
            if (!DateTime.TryParse(startDate, out start) || !DateTime.TryParse(EndDate, out end))
                return;
            List<Weather> toDelete = _weatherList.Where(x => x.Date >= start && x.Date <= end).ToList();
            foreach (Weather weather in toDelete)
            {
                if (weather.Date >= start && weather.Date <= end)
                    _weatherList.Remove(weather);
            }
        }

        private void ParseDate(string startDate, string EndDate, out DateTime start, out DateTime end)
        {
            if (!DateTime.TryParse(startDate, out start))
                start = DateTime.MinValue;
            if (!DateTime.TryParse(EndDate, out end))
                end = DateTime.MaxValue;
        }
    }
}
