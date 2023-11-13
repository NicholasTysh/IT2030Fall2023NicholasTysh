using System.ComponentModel.DataAnnotations;

namespace NickPixPlus.Models
{
    public class ContactModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Must enter valid first name as a string.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 30 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "First name can only contain alphabetic characters and spaces.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Must enter valid last name as a string.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Last name must be between 1 and 30 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Last name can only contain alphabetic characters and spaces.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Must enter valid address as a string.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Must enter valid phone number as a string.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits and contain only numbers.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Must enter valid email address as a string.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Must enter valid message as a string.")]
        public string? Message { get; set; }
    }
}
