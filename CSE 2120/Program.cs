using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_2120
{
    class Program
    {
        private static String input;
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to encrypt some stuff, or compare some other stuff?");
            input = Console.ReadLine();
            switch(input.ToLower())
            {
                case "encrypt":
                    const int keySize = 1024;
                    string publicAndPrivateKey;
                    string publicKey;

                    Secure.GenerateKeys(keySize, out publicKey, out publicAndPrivateKey);

                    string text = "Test";
                    string encrypted = Secure.EncryptText(text, keySize, publicKey);
                    string decrypted = Secure.DecryptText(encrypted, keySize, publicAndPrivateKey);
                    Console.WriteLine("Encrypted: {0}", encrypted);
                    Console.WriteLine("Decrypted: {0}", decrypted);
                    break;
                case "compare":
                    Console.WriteLine("Enter some words:");
                    input = Console.ReadLine();
                    Storage.Store(input);
                    Storage.Call(false);
                    Console.WriteLine("Enter another sentence for word use comparison:");
                    input = Console.ReadLine();
                    Storage.Store(input);
                    Storage.Call(true);
                    break;
                default:
                    Console.WriteLine("Choose either \"encypt\" or \"compare\".");
                    break;
            }
            Console.Read();
        }
    }
}
