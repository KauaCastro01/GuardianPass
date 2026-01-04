using System.Security.Cryptography;
using System.Text;

namespace GuardianPass.Utils
{
    public class HashSenha
    {
        private HashAlgorithm _algoritimo = SHA256.Create();
        
        public string CriptografarSenha(string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritimo.ComputeHash(encodedValue);
            var sb = new StringBuilder();

            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}