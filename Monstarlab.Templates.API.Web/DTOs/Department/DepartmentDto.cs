namespace Monstarlab.Templates.API.Web.DTOs.Department
{
    public class DepartmentDto
    {
        public Guid Id { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string? Floor { get; set; }

        public string? Apartment { get; set; }
    }
}
