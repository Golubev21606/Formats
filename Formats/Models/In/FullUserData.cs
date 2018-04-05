using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Formats.Models
{
    public class FullUserData
    {
        private ShortUserData shortData;

        public string Login => shortData.Login;

        public string Password => shortData.Password;

        [Required(ErrorMessage = "First name cann't be null")]
        public string FirstName { get; }

        [Required(ErrorMessage = "Last name cann't be null")]
        public string LastName { get; }
        public string Patronyme { get; }

        [DataType(DataType.DateTime, ErrorMessage = "Неверный формат даты")]
        public string DateBirth { get; }

        [Required(ErrorMessage = "Institute cann't be null")]
        public string Institute { get; }

        public string Position { get; }

        [Required(ErrorMessage = "E-mail cann't be null")]
        [EmailAddress(ErrorMessage = "Некорректный e-mail")]
        public string EMail { get; }

        public string ExtraInf { get; }

        public FullUserData(
            string login,
            string password,
            string firstName,
            string lastName,
            string patronyme,
            string dateBirth,
            string institute,
            string position,
            string email,
            string extraInf)
        {
            shortData = new ShortUserData(login, password);

            FirstName = firstName != null ? firstName.Trim() : null;
            LastName = lastName != null ? lastName.Trim() : null;
            Patronyme = patronyme != null ? patronyme.Trim() : null;
            DateBirth = dateBirth != null ? dateBirth.Trim() : null;
            Institute = institute != null ? institute.Trim() : null;
            Position = position != null ? position.Trim() : null;
            EMail = email != null ? email.Trim() : null;
            ExtraInf = extraInf != null ? extraInf.Trim() : null;
        }
    }
}
