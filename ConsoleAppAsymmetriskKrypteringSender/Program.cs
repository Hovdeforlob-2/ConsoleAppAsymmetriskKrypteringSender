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
            RSAEncrypt rsa = new RSAEncrypt();
            Gui gui = new Gui();

            const string original = "Text";
            const string publicKeyPath = @"C:\Users\Maius\Desktop\test\publickey.xml";

            string[] choicesForTheUser = { "Encrypt message" };
            gui.SetMenuHeading();
            gui.SetMenuBody(choicesForTheUser);

            int usrNo = 0;
            try
            {
                Console.WriteLine("pleace enter a number:");
                usrNo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered a non valid number");
                Console.ResetColor();
            }

            switch (usrNo)
            {
                case 1:
                    byte[] encrypted = rsa.EncryptData(publicKeyPath, Encoding.UTF8.GetBytes(original));

                    Console.WriteLine("Original Text = " + original);
                    Console.WriteLine("Encrypted Text = \n" + Convert.ToBase64String(encrypted));
                    foreach (var item in encrypted)
                    {
                        Console.Write(item + " ");
                    }

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you have entered a number there is out of range");
                    Console.ResetColor();
                    break;
            }
            Console.ReadKey();
        }
    }
}
