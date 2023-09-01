using System;
using System.Threading.Channels;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()

        {
            Console.Write("Please Enter your name: ");

            string name = Console.ReadLine();
            Console.Write($"Hello {name} enter your Binary number:  ");
            Console.ReadKey();
            string BinaryInput = Console.ReadLine();

            int decimalResult = BinaryToDecimal(BinaryInput);

            Console.WriteLine($"Decimal equivalent: {decimalResult}");





            Console.WriteLine("Would you like to Convert from Decimal Number to Binary? (yes/no: ");
            string input = Console.ReadLine().ToLower();

            if (input == "no")
            {
                Console.WriteLine("Exiting the program. ");
            }
            else if (input == "yes")
            {
                Console.Write("Enter a decimal number: ");
                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    string binaryResult = DecimalToBinary(userInput);
                    Console.WriteLine($"Binary equivalent: {binaryResult}");

                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }

            static int BinaryToDecimal(string BinaryInput)
            {
                int decimalNumber = 0;

                for (int i = BinaryInput.Length - 1, exponent = 0; i >= 0; i--, exponent++)
                {
                    int digit = BinaryInput[i] - '0';
                    if (digit != 0 && digit != 1)
                    {
                        throw new ArgumentException("Invalid Binary input");
                    }
                    decimalNumber += digit * (int)Math.Pow(2, exponent);
                }
                return decimalNumber;
                
                
            }
            static string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

                }
           
            } 
        }

