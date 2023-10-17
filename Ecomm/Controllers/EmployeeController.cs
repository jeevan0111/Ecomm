using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecomm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        public static List<Employee> listOfEmployees = new List<Employee>
        {
            new Employee{EmployeeID=101, FirstName="aa", LastName="bb"},
            new Employee{EmployeeID=102, FirstName ="jj", LastName= "mm"}
        };

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return listOfEmployees;
        }


    }
}
