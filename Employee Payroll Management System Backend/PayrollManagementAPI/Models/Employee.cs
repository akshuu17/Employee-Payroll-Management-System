using System.ComponentModel.DataAnnotations;

namespace PayrollManagementAPI.Models
{
    public class Employee
    {
        [Key]
        public int EPFNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string Position { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        public int BasicSalary { get; set; }

        public int TravellingAllowance { get; set; }

        public int SalaryAdvance { get; set; }

        public int WorkingDays { get; set; }
    }
}