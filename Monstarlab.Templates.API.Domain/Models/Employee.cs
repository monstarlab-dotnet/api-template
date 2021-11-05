using System.ComponentModel.DataAnnotations;

namespace Monstarlab.Templates.API.Domain.Models
{
    public class Employee
    {
        [Required]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public uint Age { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}