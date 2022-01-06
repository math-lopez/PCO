using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PCO.Application.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("FullName")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "The BirthDate is Required")]
        [DisplayName("BirthDate")]
        public DateTime BirthDate { get; set; }

        [DisplayName("PasswordReminder")]
        public string PasswordReminder { get; set; }
        
        [Required(ErrorMessage = "The UserName is Required")]
        [MinLength(5)]
        [DisplayName("UserName")]
        public string UserName { get; set; }
    }
}
