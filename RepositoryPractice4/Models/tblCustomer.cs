using System.ComponentModel.DataAnnotations;

namespace RepositoryPractice4.Models
{
    public class tblCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
    }
}
