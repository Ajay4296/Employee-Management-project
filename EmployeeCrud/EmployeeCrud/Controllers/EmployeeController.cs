using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeModel; 
using Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager employeeManager;

        public EmployeeController(IEmployeeManager employeeManager)
        {
            this.employeeManager = employeeManager;
        }
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<EmployeeModel.Employee> GetAll()
        {
            return this.employeeManager.GetALLEmployee();
        }
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var result = await this.employeeManager.AddEmployee(employee);
                if (result==1)
            {
                return this.Ok(employee);
            }
                else
            {
                return this.BadRequest();
            }

        }
        [Route("DeleteEmployee")]
        [HttpDelete]
        public Employee DeleteEmployee(int id)
        {
            return this.employeeManager.DeleteEmployee(id);
        }

        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            var result = await this.employeeManager.UpdateEmployee(employee);
            if(result==1)
            {
                return this.Ok(employee);
            }
            else 
            {
                return this.BadRequest();
            }
        }
        [Route("LoginEmployee")]
        [HttpGet]
        public IActionResult Login(int Id, string password)
        {
            Employee employee = this.employeeManager.GetEmployee(Id);
            if (employee != null)
            {
                if (employee.Password == password)
                {
                    return this.Ok(employee);
                }
                else
                    return this.NotFound("Please enter valid id and passworg!!");
            }
            return this.NotFound("Please enter valid id and passworg!!");
        }

    }
}