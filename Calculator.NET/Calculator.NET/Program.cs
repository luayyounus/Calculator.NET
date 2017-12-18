using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
namespace Calculator.NET
{
    class Program
    {
        private static void WelcomeMessage()
        {
            Console.WriteLine(
                "\n\n  --------------------------- Welcome to Calculator.NET! --------------------------" +
                "\n\n Enter any calculation you would like to perform using any of the four operators" +
                "\n\n\n\t\t\t\t `+` `-` `*` `/`                                      " +
                "\n" +
                "\n\tExamples: 45 + 16" +
                "\n\t          65 * 4 / 531" +
                "\n\t          49 - 2 + 134 * 648" +
                "\n\n\n");
        }

        static void Main(string[] args)
        {
            WelcomeMessage();

            Console.WriteLine("-> Calculate ");

            bool calculatorOn = true;
            while (calculatorOn)
            {
                //Make calculation
            }

            //Exit message
        }

    }
}
