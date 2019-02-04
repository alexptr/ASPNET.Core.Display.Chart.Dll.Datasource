using Ir.DeveloperTest;

namespace Test.Data.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Test.Data.Entities;
    public interface IGenericRepository
    {
        List<ChartSeriesTest> GetAsync();
    }
}
