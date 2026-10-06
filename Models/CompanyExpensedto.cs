namespace ExpenseMangementSystem.Models
{
    public class CompanyExpensedto
    {
        public string ? EmployeName { get; set; } = null!;
        public string? Email { get; set; } = null!;

        public string ? Phone { get; set; } = null!;
        public string ? Department { get; set; } = null!;
        public decimal ? Salary { get; set; }
        public bool ?  IsActive { get; set; }

    }
}
