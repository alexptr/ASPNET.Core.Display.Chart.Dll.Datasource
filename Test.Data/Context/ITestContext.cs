using Microsoft.EntityFrameworkCore;
using Test.Data.Entities;

namespace Test.Data.Context
{
    public interface ITestContext
    {
        DbSet<ChartSeriesTest> ChartDatas { get; set; }
    }
}
