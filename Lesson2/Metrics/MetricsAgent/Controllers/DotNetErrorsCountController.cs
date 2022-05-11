using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
	[Route("api/dotnet/errors-count/")]
	[ApiController]
	public class DotNetErrorsCountControllerr : ControllerBase
	{
		[HttpGet("from/{fromTime}/to/{toTime}")]

		public IActionResult GetMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
		{
			return Ok();
		}
	}
}
 