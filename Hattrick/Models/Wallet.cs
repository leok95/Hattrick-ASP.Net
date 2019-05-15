using System;
using System.ComponentModel.DataAnnotations;

namespace Hattrick.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }

        public bool IsEmpty { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Value { get; set; }
    }
}