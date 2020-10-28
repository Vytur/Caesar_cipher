using System;

namespace Caesar_cipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decipher or encipher? (type letter D or E)");
            string operation = Console.ReadLine().ToLower();
          
            Console.WriteLine("Type a string");
            string data = Console.ReadLine();

            Console.WriteLine("Enter key");
            if (!Int32.TryParse(Console.ReadLine(), out int key)) key = 0;
            else key = Math.Abs(key); // if key was set to negative value

            if (operation == "d")
            {
                Console.WriteLine("Ciphertext: " + data);
                Console.WriteLine("Plaintext:  " + Decryption(data, key));
            }
            else if(operation == "e")
            {
                Console.WriteLine("Plaintext:  " + data);
                Console.WriteLine("Ciphertext: " + Encryption(data, key));
            }

            Console.ReadKey();
        }

        public static string Encryption(string data, int key)
        {
            string encryptedData = String.Empty; // string set to an empty not null, because later its value will be assigned
            foreach (var letter in data)
            {
                encryptedData += CaesarCipher(letter, key);
            }
            return encryptedData;
        }

        public static string Decryption(string data, int key) => Encryption(data, (26 - (key % 26))); // if the key is larger than 26, the remainder is applied


        public static char CaesarCipher(char letter, int key)
        {
            if (Char.IsWhiteSpace(letter)) return (char)32;
            else if (!Char.IsLetter(letter)) return letter;
            else
            {
                int letterOffset = Char.IsUpper(letter) ? 65 : 97; // calculating ASCII character code offset
                return (char)((((letter + key) - letterOffset) % 26) + letterOffset);
            }
        }
    }
}
