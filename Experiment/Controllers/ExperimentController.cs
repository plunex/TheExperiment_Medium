
using Experiment.Procedure;
using Experiment.Sample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Experiment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExperimentController : ControllerBase
    {
       
        [HttpGet("CarryOutExperiment1")]
        public IActionResult CarryOutExperiment1()
        {
            var samples = new Samples();
            var sample = samples.getSample1();
            var procedures = new Procedures();
            var type = procedures.getSampleType(sample);

            var result = $"{sample} is of type {type}";

            return Ok(result);
        }


        [HttpGet("CarryOutExperiment2")]
        public IActionResult CarryOutExperiment2()
        {
            var samples = new Samples();
            var sample = samples.getSample2();
            var procedures = new Procedures();
            var type = procedures.getSampleType(sample);

            var result = $"{sample} is of type {type}";
            return Ok(result);
        }
    }
}
