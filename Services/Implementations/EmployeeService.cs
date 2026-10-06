using ExpenseMangementSystem.Models;
using ExpenseMangementSystem.Repositories.Interfaces;
using ExpenseMangementSystem.Services.Interfaces;
using System.ComponentModel;

namespace ExpenseMangementSystem.Services.Implementations
{
   

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;


        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public async Task<IEnumerable<CompanyExpense>> GETalldata()
        {
            return await _employeeRepository.GETalldata();
        }

        public async Task<CompanyExpense?> GETalldatabyId(int id)
        {
            return await _employeeRepository.GETalldatabyId(id);
        }

        public async Task<bool> insertdata(CompanyExpense company)
        {
            return await _employeeRepository.insertdata(company);
        }

        public async Task<bool> updatedata(int id, CompanyExpensedto companyExpensedto)
        {
            return await _employeeRepository.updatedata(id , companyExpensedto);
        }































        //private readonly IEmployeeRepository _employeeRepository;

        //public EmployeeService(IEmployeeRepository employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;
        //}

        //public async Task<IEnumerable<CompanyExpense>> GetEmployeeData()
        //{
        //    return await _employeeRepository.GetEmployeeData();

        //}

    }
}
