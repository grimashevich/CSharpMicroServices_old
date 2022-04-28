using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lesson1.Controllers
{
    [Route("api/curd")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        private WeatherHolder _holder;

        public CrudController(WeatherHolder holder)
        {
            _holder = holder;
        }

        [HttpPost("add-weather")]
        public IActionResult Create([FromQuery] int temp, [FromQuery] string date)
        {
            _holder.AddWeather(new Weather(temp, date));
            return Ok();
        }
        
        [HttpGet("get-weather")]
        public IActionResult Read(string stardDate, [FromQuery] string endDate)
        {
            return Ok(_holder.GetWeather(stardDate, endDate));
        }


        [HttpPatch("update-weather")]
        public IActionResult Update([FromQuery] int temp, [FromQuery] string date)
        {
            return Ok(_holder.UpdateWeather(date, temp));
        }

        [HttpDelete("delete-weather")]
        public IActionResult Delete([FromQuery] string stardDate, [FromQuery] string endDate)
        {
            _holder.DeleteWeather(stardDate, endDate);
            return Ok();
        }
    } 
}
