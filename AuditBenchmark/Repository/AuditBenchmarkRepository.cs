using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditBenchmark.Repository;
using AuditBenchmarkService;
using AuditBenchmark.Models;

namespace AuditBenchmarkService.Repository
{
    public class AuditBenchmarkRepository : IAuditBenchmarkRepository
    {
        private List<AuditBenchmarkModel> answers;
        public AuditBenchmarkRepository()
        {
            answers = new List<AuditBenchmarkModel>{
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 5},
                new AuditBenchmarkModel { AuditType = "SOX" , BenchmarkNoAnswers = 4},
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 3},
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 2},
                new AuditBenchmarkModel { AuditType = "SOX" , BenchmarkNoAnswers = 1},
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 0},
                new AuditBenchmarkModel { AuditType = "SOX" , BenchmarkNoAnswers = 0},

            };
        }
        public List<AuditBenchmarkModel> GetAll()
        {
            return answers;
        }

        

        
    }


}










/*using AuditBenchmark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmark.Repository
{
    public class AuditBenchmarkRepository
    {
        public class AuditBenchmarkRepository : IAuditBenchmarkRepository
        {
            private List<AuditBenchmarkModel> answers;
            public AuditBenchmarkRepository()
            {
                answers = new List<AuditBenchmarkModel>{
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 5},
                new AuditBenchmarkModel { AuditType = "SOX" , BenchmarkNoAnswers = 4},
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 3},
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 2},
                new AuditBenchmarkModel { AuditType = "SOX" , BenchmarkNoAnswers = 1},
                new AuditBenchmarkModel { AuditType = "Internal" , BenchmarkNoAnswers = 0},
                new AuditBenchmarkModel { AuditType = "SOX" , BenchmarkNoAnswers = 0},

            };
            }

            public AuditBenchmarkRepository(List<AuditBenchmarkModel> answers)
            {
                this.answers = answers;
            }

            public AuditBenchmarkModel Answers(AuditBenchmarkModel entity)
            {
                throw new NotImplementedException();
            }

            public List<AuditBenchmarkModel> GetAll()
            {
                return answers;
            }
        }
    }
}*/
