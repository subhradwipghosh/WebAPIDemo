using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTry30Sept21.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationTry30Sept21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> Employees = new List<Employee>
        {
            new Employee(){Id=101, Name="Bijit"},
            new Employee(){Id=102, Name="Mimo"}
        };

        private CompanyContext context;
        public EmployeeController(CompanyContext context)
        {
            this.context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return context.EmployeesDatabase.ToList(); 
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return context.EmployeesDatabase.FirstOrDefault(emp => emp.Id == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            context.EmployeesDatabase.Add(employee);
            context.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            Employee employee1 = context.EmployeesDatabase.FirstOrDefault(emp=>emp.Id==id);
            employee1.Name = employee.Name;
            context.SaveChanges();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.EmployeesDatabase.Remove(context.EmployeesDatabase.FirstOrDefault(emp=>emp.Id==id));
            context.SaveChanges();
        }
    }
}
