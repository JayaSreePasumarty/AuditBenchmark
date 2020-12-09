using AuditBenchmark.Models;
using AuditBenchmark.Provider;
using AuditBenchmark.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmark.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchmarkController : ControllerBase
    {
        //static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuthBenchmarkController));

        private readonly IAuditBenchmarkProvider _auditbenchmarkprovider;
        
        public AuditBenchmarkController(IAuditBenchmarkProvider auditbenchmarkprovider)
        {
            _auditbenchmarkprovider = auditbenchmarkprovider;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                //_log4net.Info("Http get request initiated with " + AuditType);
                var result = _auditbenchmarkprovider.GetAll();
                return Ok(result);
            }
            catch (Exception e)
            {
               // _log4net.Error("No content Obtained " + e.Message);
                return new NoContentResult();
            }
        }
    }
}

