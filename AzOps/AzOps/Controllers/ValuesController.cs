using AzOps.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AzOps.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly List<EmployeeInfo> empinfo;
        public ValuesController()
        {
            empinfo = new List<EmployeeInfo>{
                new EmployeeInfo { id = 1, EmpName = "Pramod", dept = "IT", Designation = "Software Developer", Salary = 100 },
                new EmployeeInfo { id = 2, EmpName = "Kailas", dept = "TA", Designation = "Software Developer", Salary = 200 },
                new EmployeeInfo { id = 3, EmpName = "Ranjeet", dept = "IT", Designation = "Software Developer", Salary = 300 },
                new EmployeeInfo { id = 4, EmpName = "Alex", dept = "App", Designation = "Software Developer", Salary = 400 },
                new EmployeeInfo { id = 5, EmpName = "Kishore", dept = "IT", Designation = "Software Developer", Salary = 500 },
                new EmployeeInfo { id = 6, EmpName = "Pragya", dept = "TA", Designation = "Software Developer", Salary = 600 },
                new EmployeeInfo { id = 7, EmpName = "Chaitra", dept = "Automation", Designation = "Software Developer", Salary = 700 }
            };
        }
        // GET api/values
        public IEnumerable<EmployeeInfo> Get()
        {
            return empinfo;
        }

        // GET api/values/5
        public EmployeeInfo Get(int id)
        {
            return empinfo.Where(a => a.id == id).FirstOrDefault();
        }

        // POST api/values
        public IEnumerable<EmployeeInfo> Post([FromBody]EmployeeInfo value)
        {
            empinfo.Add(value);
            return empinfo;
        }

        // PUT api/values/5
        public IEnumerable<EmployeeInfo> Put(int id, [FromBody]EmployeeInfo value)
        {
            EmployeeInfo emp = empinfo.Where(a => a.id == id).FirstOrDefault();

            empinfo.Remove(emp);
            empinfo.Add(value);
            return empinfo;
        }

        // DELETE api/values/5
        public IEnumerable<EmployeeInfo> Delete(int id)
        {
            EmployeeInfo emp = empinfo.Where(a => a.id == id).FirstOrDefault();
            empinfo.Remove(emp);
            return empinfo;
        }
    }
}
