using AuditBenchmark.Models;
using AuditBenchmarkService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmark.Repository
{
    public interface IAuditBenchmarkRepository
    {

        public List<AuditBenchmarkModel> GetAll();
        



    }
}
