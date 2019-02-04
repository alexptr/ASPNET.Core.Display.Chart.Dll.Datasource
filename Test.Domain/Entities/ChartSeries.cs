namespace Test.Domain.Entities
{
    using System.Collections.Generic;

    public class ChartSeries
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<ChartPoint> Points { get; set; }
    }
}
