using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Text;

namespace QLHS_WEB_API.Helper
{
    public class CryptoUtil
    {
        public static int DERIVATION_KEY_LENGTH = 64;
        public static int ITERATION_COUNT = 100000;
        private const string m_a = "9006f149-aa49-4b8e-ba69-386d945fa738";

        public static byte[] HashPassword(byte[] password, byte[] salt)
        {
            byte[] bytes = new Rfc2898DeriveBytes(password, salt, ITERATION_COUNT, HashAlgorithmName.SHA512).GetBytes(DERIVATION_KEY_LENGTH);
            byte[] array = new byte[bytes.Length + salt.Length];
            Array.Copy(bytes, 0, array, 0, bytes.Length);
            Array.Copy(salt, 0, array, bytes.Length, salt.Length);
            return array;
        }
        public static byte[] GetSalt(string userName)
        {
            byte[] bytes1 = Encoding.UTF8.GetBytes(m_a);
            byte[] bytes2 = Encoding.UTF8.GetBytes(userName);
            byte[] array = new byte[bytes1.Length + bytes2.Length];
            Array.Copy(bytes1, 0, array, 0, bytes1.Length);
            Array.Copy(bytes2, 0, array, bytes1.Length, bytes2.Length);
            return SHA256.HashData(array);
        }
    }
}
