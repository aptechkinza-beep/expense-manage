using ExpenseMangementSystem.Models;

namespace ExpenseMangementSystem.Repositories.Interfaces
{

    public interface IEmployeeRepository
    {
        public Task<IEnumerable<CompanyExpense>> GETalldata();
        public Task<CompanyExpense?> GETalldatabyId(int id);
        public Task<bool>  insertdata(CompanyExpense company);

        public Task<bool> updatedata(int id, CompanyExpensedto companyExpensedto);
     }
}
 
