using System.ComponentModel.DataAnnotations;

namespace NickPixPlus.Models
{
    public class ContactModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Must enter valid first name as a string.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Must enter valid last name as a string.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Must enter valid address as a string.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Must enter valid phone number as a string.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Must enter valid email address as a string.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Must enter valid message as a string.")]
        public string? Message { get; set; }
    }
}
