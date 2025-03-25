using System;

namespace GenerateQR
{
    public class QRGenerator
    {
        public static string Generate(string input)
        {
            return $"QR:{input}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(QRGenerator.Generate("HelloWorld"));
        }
    }
}
