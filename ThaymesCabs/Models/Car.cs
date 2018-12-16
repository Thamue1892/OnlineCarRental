using System.ComponentModel.DataAnnotations;

namespace ThaymesCabs.Models
{
    public class Car
    {
        public int CarId { get; set; }

        [Required]
        public string CarRegistration { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }
    }
}