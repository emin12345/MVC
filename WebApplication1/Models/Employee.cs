using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(18, 65)]
        public int Age { get; set; }

        [Range(1000, 100000)]
        public decimal Salary { get; set; }
    }
}