using Test.Domain.Interfaces;

namespace Test.WebAPI.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Test.DTO;

    [Route("api/[controller]")]
    [ApiController]
    public class ChartDataValuesController : ControllerBase
    {
        private readonly IChartService chartService;

        public ChartDataValuesController(IChartService chartService)
        {
            this.chartService = chartService;
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<ChartSeriesDTO>> GetChartData()
        {
            var result = this.chartService.GetAllData();

            return Ok(result);
        }
    }
}
