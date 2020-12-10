using AuditBenchmark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmark.Provider
{
    public interface IAuditBenchmarkProvider
    {
        List<AuditBenchmarkModel> GetAll();
    }
}