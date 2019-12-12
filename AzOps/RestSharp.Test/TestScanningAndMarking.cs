using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp.Test.Business;
using RestSharp.Test.Models;
using System.Collections.Generic;

namespace RestSharp.Test
{
    [TestClass]
    public class TestScanningAndMarking
    {
        private readonly ScanningAndMarking scanmark;

        public TestScanningAndMarking()
        {
            scanmark = new ScanningAndMarking();
        }

        [TestMethod]
        [Ignore]
        public void TestCreateEmployee()
        {
            //RestClient client = new RestClient("http://localhost:3000/");
            //var request = new RestRequest("posts/{id}", Method.GET);
            //request.AddUrlSegment("id", 1);

            //var response = client.Execute(request);


            ////Newtonsoft json object

            ////JObject objResponse = JObject.Parse(response.Content);

            //var deserialize = new JsonDeserializer();
            //var output = deserialize.Deserialize<Dictionary<string, string>>(response);


            EmployeeInfo response = scanmark.Create(new
                Models.EmployeeInfo
                                {
                                    id = 7,
                                    EmpName = "Chaitra Tilak",
                                    Salary = 700,
                                    dept = "IT",
                                    Designation = "Software developer"
                                });
        }

        [TestMethod]
        [Ignore]
        public void TestGetEmployeeById()
        {
            EmployeeInfo info = scanmark.Get(1);
            Assert.IsNotNull(info);
        }

        [TestMethod]
        [Ignore]
        public void TestGetAllEmployee()
        {
            List<EmployeeInfo> info = scanmark.Get();
            Assert.IsNotNull(info);
            Assert.AreNotEqual(0, info.Count);
        }

        [TestMethod]
        [Ignore]
        public void TestUpdateEmployee()
        {
            string response = scanmark.Update(5, new Models.EmployeeInfo
            {
                id = 5,
                EmpName = "Wayne",
                Salary = 500,
                dept = "Scrum team",
                Designation = "Scrum Master"
            });
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [Ignore]
        public void TestDeleteEmployee()
        {
            string response = scanmark.Delete(7);
            Assert.IsNotNull(response);
        }
    }
}
