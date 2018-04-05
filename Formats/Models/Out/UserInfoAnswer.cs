using System.Collections.Generic;

namespace Formats.Models
{
    public class UserInfo
    {
        public string Login { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Patronyme { get; }
        public string DateBirth { get; }
        public string Institute { get; }
        public string Position { get; }
        public string EMail { get; }
        public string ExtraInf { get; }

        public UserInfo(
            string login = "",
            string firstName = "",
            string lastName = "",
            string patronyme = "",
            string dateBirth = "",
            string institute = "",
            string position = "",
            string email = "",
            string extraInf = "")
        {
            Login = login.Trim();
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
            Patronyme = patronyme.Trim();
            DateBirth = dateBirth.Trim();
            Institute = institute.Trim();
            Position = position.Trim();
            EMail = email.Trim();
            ExtraInf = extraInf.Trim();
        }
    }

    public class UserInfoAnswer
    {
        public string Status { get; }
        public List<string> Errors { get; set; }
        public UserInfo User { get; }

        public UserInfoAnswer(
            Status status,
            IEnumerable<string> errors = null,
            string login = null,
            string firstName = null,
            string lastName = null,
            string patronyme = null,
            string dateBirth = null,
            string institute = null,
            string position = null,
            string email = null,
            string extraInf = null)
        {
            Status = status.ToString();

            if (errors != null)
            {
                Errors.AddRange(errors);
            }

            User = new UserInfo(login, firstName, lastName, patronyme, dateBirth, institute, position, email, extraInf);
        }
    }
}