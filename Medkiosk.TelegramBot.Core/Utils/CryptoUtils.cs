using System;
using System.Security.Cryptography;
using System.Text;

namespace Medkiosk.TelegramBot.Core.Utils
{
    public static class CryptoUtils
    {
        /// <summary>
        /// Получить хэш пароля
        /// </summary>
        public static string GetPasswordHash(string password)
        {
            using (var hashAlg = SHA256.Create())
            {
                return BitConverter.ToString(
                    hashAlg.ComputeHash(Encoding.UTF8.GetBytes(password))).Replace("-", "").ToLower();
            }
        }
    }
}