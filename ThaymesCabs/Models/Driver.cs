using System.ComponentModel.DataAnnotations;

namespace ThaymesCabs.Models
{
    public class Driver
    {
        public int DriverId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string LicenceNumber { get; set; }

        [Required]
        public int Age { get; set; }
    }
}