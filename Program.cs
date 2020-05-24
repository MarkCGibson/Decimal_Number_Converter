using System;

namespace Decimal_Converter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Define arrays of possible values
            char[] octals = { '0', '1', '2', '3', '4', '5', '6', '7' };
            char[] hexadecimals = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            char[] binaries = { '0', '1' };

            // Print out the introduction code
            Console.WriteLine("Welcome to the decimal number converter!");
            
            //define a proceed with the program variable
            bool  proceed = true;
            while (proceed)
            {
                Console.WriteLine("Please enter the number to be converted");

                // User inputs the number in decimal to be converted
                Console.Write("Number: ");
                long number;

                // Checks if the number is a decimal integer
                while (long.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.WriteLine("Please make sure your number is an integer");
                }

                // Creates a num to convert object
                NumToConvert num = new NumToConvert(number);

                // Starts the output
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"Your number in decimal is {num.Number}");

                // Converts to binary
                string resultBin = num.ConvertToBaseX(2, binaries);
                Console.WriteLine($"Your number in binary is {resultBin}");

                // Convert to Octal
                string resultOct = num.ConvertToBaseX(8, octals);
                Console.WriteLine($"Your number in octal is {resultOct}");

                // Converts to hexadecimal
                string resultHex = num.ConvertToBaseX(16, hexadecimals);
                Console.WriteLine($"Your number in hexadecimal is {resultHex}\n");

                // Check if the user wants to enter another number
                Console.WriteLine("Would you like to enter another number? (Y/N)");
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    proceed = false;
                }
            }
                 
            Console.WriteLine("Thank you for using the decimal number converter. \nPress any key to exit");
            Console.ReadKey();
        }
    }
}





