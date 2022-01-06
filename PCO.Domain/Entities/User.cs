using PCO.Domain.Validations;
using System;
using System.Collections.Generic;

namespace PCO.Domain.Entities
{
    public class User : Entity
    {
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Password { get; private set; }
        public string PasswordReminder { get; private set; }
        public string UserName { get; private set; }
        public int MinitryId { get; set; }
        public ICollection<MinistryUser> MinistriesUsers { get; set; }

        public User(int id, string fullName, DateTime birthDate, string password, string passwordReminder, string userName)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;
            CreatedDate = new DateTime();
            Validation(fullName, birthDate, password, passwordReminder, userName);
        }

        public User(string fullName, DateTime birthDate, string password, string passwordReminder, string userName)
        {
            Validation(fullName, birthDate, password, passwordReminder, userName);
        }

        private void Validation(string fullName, DateTime birthDate, string password, string passwordReminder, string userName)
        {
            DomainExceptionValidation.When(fullName.Equals(null), "Invalid full name value.");
            DomainExceptionValidation.When(fullName.Length < 5, "Full name must be at least 5 characters long.");
            DomainExceptionValidation.When(birthDate.Equals(null), "Invalid birth date value.");
            DomainExceptionValidation.When(password.Equals(null), "Invalid password value.");
            DomainExceptionValidation.When(password.Length < 5, "Password must be at least 5 characters long.");
            DomainExceptionValidation.When(userName.Length < 5, "userName must be at least 5 characters long.");

            FullName = fullName;
            BirthDate = birthDate;
            Password = password;
            PasswordReminder = passwordReminder;
            UpdateDate = new DateTime();
            UserName = userName;
        }
    }

}
