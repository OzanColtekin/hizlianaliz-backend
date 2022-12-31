using System.Security.Cryptography;
using System.Text;

namespace UIProject.Models.Security
{
    public class Crypto
    {
        public string GetSHA1(string ps)
        {
            StringBuilder hash = new();
            var sha = SHA1.Create();
            byte[] inputbytes = sha.ComputeHash(new UTF8Encoding().GetBytes(ps));
            for (int i = 0; i < inputbytes.Length; i++)
            {
                hash.Append(inputbytes[i].ToString("x2"));
            }
            return hash.ToString();

        }

        public string GetMD5(string ps)
        {
            StringBuilder hash = new();
            var md = MD5.Create();
            byte[] inputbytes = md.ComputeHash(new UTF8Encoding().GetBytes(ps));
            for (int i = 0; i < inputbytes.Length; i++)
            {
                hash.Append(inputbytes[i].ToString("x2"));
            }
            return hash.ToString();

        }
    }
}
