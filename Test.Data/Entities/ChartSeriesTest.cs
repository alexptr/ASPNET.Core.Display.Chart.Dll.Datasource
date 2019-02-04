using System.Collections.Generic;

namespace Test.Data.Entities
{
    using Ir.DeveloperTest;

    public class ChartSeriesTest : IChartSeries
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IList<IChartPoint> Points { get; set; }
    }
}
