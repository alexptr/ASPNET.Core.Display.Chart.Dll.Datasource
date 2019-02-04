using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ir.DeveloperTest;
using Test.Data.Context;
using Test.Data.Entities;
using Test.Data.Interfaces;

namespace Test.Data.Repositories
{
    using Microsoft.EntityFrameworkCore;

    public class GenericRepository : IGenericRepository
    {
        public IChartData chartData;
        public GenericRepository(IChartData data)
        {
            this.chartData = data;
        }

        public List<ChartSeriesTest> GetAsync()
        {
            return chartData.Get().Select(x => new ChartSeriesTest(){Id = x.Id, Name = x.Name, Points = x.Points}).ToList();
        }
       
    }
}
