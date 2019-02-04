namespace Test.Data.Context
{
    using Microsoft.EntityFrameworkCore;
    using Test.Data.Entities;

    public class TestContext : DbContext
    {


        public TestContext()
        {

        }

        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }

        public DbSet<ChartSeriesTest> ChartDatas { get; set; }
    }
}
