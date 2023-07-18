using System;

namespace Gammis
{
    public class RefCodeGenerator
    {
        private static readonly Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public string GenerateRefCode(int length)
        {
            var refCodeBuilder = new System.Text.StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                refCodeBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return refCodeBuilder.ToString();
        }
    }

    public class Program
    {
        public static void Main()
        {
            int refCodeLength = 10; // Length of the ref_code
            RefCodeGenerator refCodeGenerator = new RefCodeGenerator();

            while (true)
            {
                Console.WriteLine("WELCOME TO CUM-CLI GENERATER");

                Console.ForegroundColor = ConsoleColor.Blue;
                string refCode = refCodeGenerator.GenerateRefCode(refCodeLength);

                // Change the console text color to green for the label text
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Your session generated ref_code: ");

                // Change the console text color to red for the refCode itself
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(refCode);

                // Reset the console text color to default
                Console.ResetColor();

                Console.WriteLine("Press Enter to generate another refcode or type 'exit' to quit.");

                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
            }
        }
    }
}
