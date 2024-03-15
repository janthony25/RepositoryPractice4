﻿using System.ComponentModel.DataAnnotations;

namespace RepositoryPractice4.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
    }
}
