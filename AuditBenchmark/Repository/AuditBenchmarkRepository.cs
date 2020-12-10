using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditBenchmark.Repository;
using AuditBenchmarkService;
using AuditBenchmark.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuditBenchmarkService.Repository
{
    public class AuditBenchmarkRepository : IAuditBenchmarkRepository
    {
        private List<AuditBenchmarkModel> answers;
        public AuditBenchmarkRepository()
        {
            answers = new List<AuditBenchmarkModel>{
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 3},
                new AuditBenchmarkModel { AuditType = "SOX" , BenchmarkNoAnswers = 1},
                
            };
        }
         public List<AuditBenchmarkModel> GetAll()
         {
             return answers;
         }
           
    }
}










