using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
namespace MetricsAgent.Controllers
{
	[Route("api/metrics/ram/available/")]
	[ApiController]
	public class RAMController : ControllerBase
	{
		[HttpGet("from{fromTime}/to/{toTime}")]
		public IActionResult GetMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
		{
			return Ok();
		}
	}
}
