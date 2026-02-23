using Microsoft.EntityFrameworkCore;
using PayrollManagementAPI.Models;

namespace PayrollManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<SalaryGrade> SalaryGrades { get; set; }

        public DbSet<Payslip> Payslips { get; set; }
    }
}