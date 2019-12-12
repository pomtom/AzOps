using RestSharp.Test.Models;
using System.Collections.Generic;

namespace RestSharp.Test.Business
{
    public interface IScanningAndMarking
    {
        List<EmployeeInfo> Get();
        EmployeeInfo Get(int id);
        EmployeeInfo Create(EmployeeInfo entity);
        string Update(int id, EmployeeInfo entity);
        string Delete(int id);
    }
}
