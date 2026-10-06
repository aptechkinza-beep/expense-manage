using ExpenseMangementSystem.Models;

namespace ExpenseMangementSystem.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<CompanyExpense>> GETalldata();
        public Task<CompanyExpense?> GETalldatabyId(int id);
        public Task<bool> insertdata(CompanyExpense company);

        public Task<bool> updatedata(int id, CompanyExpensedto companyExpensedto);
    }
}
