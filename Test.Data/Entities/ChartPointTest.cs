using System;
using System.Collections.Generic;
using System.Text;
using Ir.DeveloperTest;

namespace Test.Data.Entities
{
    public class ChartPointTest : IChartPoint
    {
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}
