namespace EmployeeAdminPortalAPI.Models
{
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; } ///? makes it nullable 
        public decimal Salary { get; set; }
    }
}
