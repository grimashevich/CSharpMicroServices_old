using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTests
{
    public class CpuMetricControllerTests
    {
        CpuMetricsController _cpuMetricController;

        public CpuMetricControllerTests()
		{
            _cpuMetricController = new CpuMetricsController();
		}

        [Fact]
        public void ReturnTypeTest()
        {
            TimeSpan t1 = TimeSpan.FromSeconds(1);
            TimeSpan t2 = TimeSpan.FromSeconds(2);

            IActionResult result =  _cpuMetricController.GetMetrics(t1, t2);
            Assert.IsAssignableFrom<IActionResult>(result);

            // TODO: �������� ������� [����� 3]
            //  �������� ������ � ������� ��� ������ ����� ������. �������� ������� Unit-����� �� ������
            // ����� �������� ������� ����������� � ����� �������� ��������.

            // �� ������ ������ ����� ������ ��������������� ���������� (��� � ������� MetricsManagerTests)
        }
    }
}
