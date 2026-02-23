using System.ComponentModel.DataAnnotations;

namespace PayrollManagementAPI.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
    }
}