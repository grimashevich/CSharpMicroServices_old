using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
	[Route("api/network/")]
	[ApiController]
	public class NetworkController : ControllerBase
	{

		[HttpGet("from{fromTime}/to/{toTime}")]

		public IActionResult GetMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
		{
			return Ok();
		}
	}
}
