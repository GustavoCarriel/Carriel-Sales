using System.Text;
using System.Security.Cryptography;

namespace CarrielAPI.Utilities
{
    public class UsuarioUtilities
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertendo a senha para um array de bytes
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Calculando o hash da senha
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convertendo o hash para uma string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
