using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAsymmetriskKrypteringSender
{
    class Program
    {
        static void Main(string[] args)
        {
            var rsa = new RSA();

            const string original = "Text";
            const string publicKeyPath = @"C:\Users\Maius\Desktop\test\publickey.xml";
            const string privateKeyPath = @"C:\Users\Maius\Desktop\test\privatekey.xml";

            //rsa.AssignNewKey(publicKeyPath, privateKeyPath);
            var encrypted = rsa.EncryptData(publicKeyPath, Encoding.UTF8.GetBytes(original));
            var decrypted = rsa.DecryptData(privateKeyPath, encrypted);

            Console.WriteLine("Xml Based Key");
            Console.WriteLine();
            Console.WriteLine("Original Text = " + original);
            Console.WriteLine();
            Console.WriteLine("Encrypted Text = \n" + Convert.ToBase64String(encrypted));
            Console.WriteLine();
            Console.WriteLine("Decrypted Text = " + Encoding.Default.GetString(decrypted));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
