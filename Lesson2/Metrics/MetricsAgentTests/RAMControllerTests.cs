using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetricsAgentTests
{
	public class RAMControllerTests
	{
		RAMController _ramController;

		public RAMControllerTests()
		{
			_ramController = new RAMController();
		}

		[Fact]
		public void ReturnTypeTest()
		{
			TimeSpan t1 = TimeSpan.FromSeconds(1);
			TimeSpan t2 = TimeSpan.FromSeconds(2);

			IActionResult result = _ramController.GetMetrics(t1, t2);
			Assert.IsAssignableFrom<IActionResult>(result);
		}
	}
}
