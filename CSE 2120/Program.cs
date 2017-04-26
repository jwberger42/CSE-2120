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
            //Request userin for the code
            Console.WriteLine("Do you want to encrypt some stuff, or compare some other stuff?");
            input = Console.ReadLine();
            //Switch the userin depending on what they say
            switch(input.ToLower())
            {
                case "encrypt":
                    //Encrypt the inputted data
                    Console.WriteLine("Enter the string to be encrypted:");
                    //Take the inputted data
                    input = Console.ReadLine();
                    //Set the max key size
                    const int keySize = 1024;
                    //Initialize the required key vars
                    string publicAndPrivateKey;
                    string publicKey;
                    //Run the generation process on the Secure class
                    Secure.GenerateKeys(keySize, out publicKey, out publicAndPrivateKey);
                    //Initialize the input var
                    string text = input;
                    //Initialize, and populate the string as encrypted
                    string encrypted = Secure.EncryptText(text, keySize, publicKey);
                    //Print encrypted string, and ask if user wants the string to be decrypted again
                    Console.WriteLine("Encrypted: {0}", encrypted);
                    Console.WriteLine("Do you want to decrypt?");
                    //Take user input
                    input = Console.ReadLine();
                    //If they say yes
                    if(input.Contains("yes"))
                    {
                        //Decrypts data based on the keys
                        string decrypted = Secure.DecryptText(encrypted, keySize, publicAndPrivateKey);
                        //Print original string
                        Console.WriteLine("Decrypted: {0}", decrypted);
                    }
                    break;
                case "compare":
                    //Request the user to type stuff in
                    Console.WriteLine("Enter some words:");
                    //Take said input
                    input = Console.ReadLine();
                    //Run storage modules
                    Storage.Store(input);
                    Storage.Call(false);
                    //Tell user to type in next string
                    Console.WriteLine("Enter another sentence for word use comparison:");
                    //Populate input
                    input = Console.ReadLine();
                    //Run storage the second time with true modifier
                    Storage.Store(input);
                    Storage.Call(true);
                    break;
                default:
                    //Tell user they are not smart, and chose the wrong thing
                    Console.WriteLine("Choose either \"encypt\" or \"compare\".");
                    break;
            }
            //wait for user to hit enter to end and end program
            Console.Read();
        }
    }
}
