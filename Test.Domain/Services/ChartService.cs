

using System.Linq;

namespace Test.Domain.Services
{

    using System.Threading.Tasks;
    using Test.Data.Entities;
    using Test.Data.Interfaces;
    using Test.Domain.Interfaces;
    using System.Collections.Generic;

    public class ChartService : IChartService
    {
        private readonly IGenericRepository repo;

        public ChartService(IGenericRepository repo)
        {
            this.repo = repo;
        }

        public List<ChartSeriesTest> GetAllData()
        {
            var result = repo.GetAsync().ToList() as List<ChartSeriesTest>;
            return result;
        }
    }
}
