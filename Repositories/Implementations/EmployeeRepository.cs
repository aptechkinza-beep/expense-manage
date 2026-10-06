using ExpenseMangementSystem.Models;
using ExpenseMangementSystem.Repositories.Interfaces;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Data.SqlClient;  
using Microsoft.Extensions.Configuration;          
using Dapper.Contrib.Extensions;
namespace ExpenseMangementSystem.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionstring;

        public EmployeeRepository(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("DefaultConnection")!;

        }



        public async Task<IEnumerable<CompanyExpense>> GETalldata()
        {

            var connection = new  SqlConnection(_connectionstring);

            var employee = await connection.GetAllAsync<CompanyExpense>();


            return employee;
             
        }

        public async Task<CompanyExpense?> GETalldatabyId(int id)
        {
            var connection = new SqlConnection(_connectionstring);
            var employeebyid = await connection.GetAsync<CompanyExpense>(id);
            return employeebyid;
        }

        public async Task<bool> insertdata(CompanyExpense company)
        {
            var connection = new SqlConnection(_connectionstring);
            var employeedata = await connection.InsertAsync<CompanyExpense>(company);
            return employeedata > 0;
        }

        public async Task<bool> updatedata(int id, CompanyExpensedto companyExpensedto)
        {
            var connection = new SqlConnection(_connectionstring);
            var  olddata  = await connection.GetAsync<CompanyExpense>(id);

            if (olddata == null) 
            {
                return false;
                
            }

            if (companyExpensedto.EmployeName != null)
            {
                olddata.EmployeName = companyExpensedto.EmployeName;


            }

            if (companyExpensedto.Department != null)
            {
                olddata.Department = companyExpensedto.Department;
            }

            if (companyExpensedto.Email != null)
            {
                olddata.Email = companyExpensedto.Email;
            }

            if (companyExpensedto.Salary.HasValue)
            {
                olddata.Salary = companyExpensedto.Salary.Value;
            }

            var  updatedata = await connection.UpdateAsync<CompanyExpense>(olddata);


            return updatedata;

        }
    }
}




 