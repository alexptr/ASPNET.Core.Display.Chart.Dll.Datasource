namespace Test.Domain.Interfaces
{
    using Test.Data.Entities;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    public interface IChartService
    {
        List<ChartSeriesTest>  GetAllData();
    }
}
