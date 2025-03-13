using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expenses
    {
        public int id { get; set; }


        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount needs to be larger than 0 " )]
        public double Amount { get; set; }
         

        public DateTime Date { get; set; } = DateTime.Now;


        [Required]
        public string Category { get; set; } = null!;
    }
}
