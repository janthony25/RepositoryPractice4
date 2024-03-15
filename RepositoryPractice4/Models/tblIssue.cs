using System.ComponentModel.DataAnnotations;

namespace RepositoryPractice4.Models
{
    public class tblIssue
    {
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string Issue { get; set; }
        [Required]
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        [Required]
        public string CarRego { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
    }
}
