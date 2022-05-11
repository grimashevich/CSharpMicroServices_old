﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
namespace MetricsAgent.Controllers
{
	[Route("api/metrics/hdd/left/")]
	[ApiController]
	public class HDDController : ControllerBase
	{
		[HttpGet("from{fromTime}/to/{toTime}")]
		public IActionResult GetMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
		{
			return Ok();
		}
	}
}
