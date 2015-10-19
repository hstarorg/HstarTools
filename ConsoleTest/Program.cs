using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HashAlgorithm hashAlgorithm = new SHA1CryptoServiceProvider(); //MD5CryptoServiceProvider();
            byte[] result = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes("1"));

            //获取方式1 正常获取
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sBuilder.Append(result[i].ToString("x2"));
            }
            string password = sBuilder.ToString();

            //获取方式2  乱码
           // string password = Encoding.UTF8.GetString(result);
            Console.WriteLine(password);
            Console.ReadKey();
        }
    }
}
