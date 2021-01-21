using System;
using System.Security.Cryptography;
using System.Text;

namespace LearnMD5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123");
            Console.WriteLine(s);
            Console.ReadKey();
        }

        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密

            //需要将字符串转换为字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组
            byte[] md5buffer = md5.ComputeHash(buffer);
            //将字节数组转换为字符串
            //将字节数组中每个元素按照指定的编码格式解析成字符串
            //直接将数组tostring（）
            //将字节数组中的每个元素tostring（）



            string ss = "";
            for (int i = 0; i < md5buffer.Length; i++)
            {
                ss += md5buffer[i].ToString("x2");
            }



            return ss;
        }
    }
}
