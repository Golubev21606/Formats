using System;
using System.Collections.Generic;
using System.Text;

namespace Formats.Security
{
    public static class Crypter
    {
        private static string salt = "rXkFovQPpMHClLBmbihUIcKJRVDjGafusZSOxegnTWwYzEqydNtA";

        public static string Encrypt(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            var result = new StringBuilder(text.Length == 0 ? "0" : "");
            var length = text.Length;

            for (int i = 0; i < length / 4; i++)
            {
                result.Append(text[i] * 7);
                result.Append(salt[salt.Length - i % length - 1] * 3);

                result.Append(text[length - i - 1] * 5);
                result.Append(salt[i % length] * 11);
            }

            return result.ToString();
        }
    }
}
