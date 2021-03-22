using _5951071083_Vo_Minh_Quan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071083_Vo_Minh_Quan.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var weatherInfList = new List<StudentInfo>();



            var weatherInfo = new StudentInfo
            {
                Hoten = "Vo Minh Quan",
                MaSoSv = "5951071083",
                Lop = "CQ.CNTT.K59",
                NgaySinh = new DateTime(2000, 10, 28)
            };
            weatherInfList.Add(weatherInfo);


            return weatherInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Hoten = "Vo Minh Quan",
                MaSoSv = "5951071083",
                Lop = "CQ.CNTT.K59",
                NgaySinh = new DateTime(2000, 10, 28)
            };
        }

        // POST: api/Student
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}