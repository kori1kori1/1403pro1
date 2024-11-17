using static ConsoleApp3.Classes;
namespace ConsoleApp3
{
    internal class Program
    {
        //public static object number;

        static void Main(string[] args)
        {



            Console.WriteLine("Enter a number:");
            uint number = Convert.ToUInt32(Console.ReadLine());

            // بررسی عدد به عنوان Prime
            Calculator primeCalc = CalcFactory.Factory(number, "Prime");
            bool isPrime = primeCalc.IsTrue(number);

            // بررسی عدد به عنوان Palindrome
            Calculator palindromeCalc = CalcFactory.Factory(number, "Palindrome");
            bool isPalindrome = palindromeCalc.IsTrue(number);

            string resultType = isPrime ? "Prime" : isPalindrome ? "Palindrome" : "None";

            switch (resultType)
            {
                case "Prime":
                    Console.WriteLine($"{number} is a Prime number.");
                    break;

                case "Palindrome":
                    Console.WriteLine($"{number} is a Palindrome number.");
                    break;

                default:
                    Console.WriteLine($"{number} is neither Prime nor Palindrome.");
                    break;
            }

        }
    }
}
