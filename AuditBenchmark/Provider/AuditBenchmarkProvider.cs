using AuditBenchmark.Models;
using AuditBenchmark.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmark.Provider
{
    public class AuditBenchmarkProvider : IAuditBenchmarkProvider
    {
        private IAuditBenchmarkRepository _auditbenchmarkservice;
        public AuditBenchmarkProvider(IAuditBenchmarkRepository auditbenchmarkservice)
        {
            _auditbenchmarkservice = auditbenchmarkservice;
        }

         public List<AuditBenchmarkModel> GetAll()
         {
             return _auditbenchmarkservice.GetAll();
         }

       
    }
}