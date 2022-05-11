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
	public class NetworkControllerTests
	{
		NetworkController _networkController;

		public NetworkControllerTests()
		{
			_networkController = new NetworkController();
		}

		[Fact]
		public void ReturnTypeTest()
		{
			TimeSpan t1 = TimeSpan.FromSeconds(1);
			TimeSpan t2 = TimeSpan.FromSeconds(2);

			IActionResult result =  _networkController.GetMetrics(t1, t2);
			Assert.IsAssignableFrom<IActionResult>(result);
		}
	}
}
