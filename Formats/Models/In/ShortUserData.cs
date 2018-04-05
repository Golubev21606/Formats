using Formats.Security;
using System;
using System.ComponentModel.DataAnnotations;

namespace Formats.Models
{
    public class ShortUserData
    {
        [Required(ErrorMessage = "Name must be specified")]
        public string Login { get; }

        [Required(ErrorMessage = "Password must be specified")]
        public string Password { get; }

        public ShortUserData(string login, string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Login = login ?? throw new ArgumentNullException(nameof(login));
            Password = Crypter.Encrypt(password);

            Login = Login.Trim();
            Password = Password.Trim();
        }
    }
}
