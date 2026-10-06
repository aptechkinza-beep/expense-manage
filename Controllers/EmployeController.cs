using ExpenseMangementSystem.Models;
using ExpenseMangementSystem.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseMangementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("all")]


        public async Task<IActionResult> GetEmployeeData()
        {
           var employee =  await _employeeService.GETalldata();

          return  Ok(employee);


        }



        [HttpGet("{id}")]


        public async Task<IActionResult> GetEmployeeDatabyId(int id)
        {
            var employeebyid = await _employeeService.GETalldatabyId(id);

            return Ok(employeebyid);


        }



        [HttpPost("create")]


        public async Task<IActionResult>  InsertData(CompanyExpense  company)
        {
            var employeedata = await _employeeService.insertdata(company);

            if (!employeedata)
            {
                return BadRequest("data not found");  
            }
            return Ok("data created");

        }



        [HttpPatch("{id}")]


        public async Task<IActionResult>  updatedata(int id ,[FromBody] CompanyExpensedto companyExpensedto)
        {
            var employeedata = await _employeeService.updatedata(id , companyExpensedto);

            if (!employeedata)
            {
                return BadRequest("data not found");
            }
            return Ok("update data sucessfully");


        }



    }
}
