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
                "\n\n" +
                "\t\t\t\t You can type `EXIT` any time to leave the application." +
                "\n\n");
        }

        private static bool CalculatorOn()
        {
            var userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                const string message = "Type something! :)";
                Console.WriteLine(message);
                return true;
            }

            if (userInput.ToLower() == "exit")
                return false;

            //Calculate the user input
            return true;
        }

        public static void ExitAndThankYouMessage()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(@"
                         _____  _   _  _____  _   _  _   _     _     _  _____  _   _ 
                        (_   _)( ) ( )(  _  )( ) ( )( ) ( )   ( )   ( )(  _  )( ) ( )
                          | |  | |_| || (_) || `\| || |/'/'   `\`\_/'/'| ( ) || | | |
                          | |  |  _  ||  _  || , ` || , <       `\ /'  | | | || | | |
                          | |  | | | || | | || |`\ || |\`\       | |   | (_) || (_) |
                          (_)  (_) (_)(_) (_)(_) (_)(_) (_)      (_)   (_____)(_____)




                                    |\
                            /    /\/o\_
                           (.-.__.(   __o
                        /\_(      .----'
                         .' \____/
                        /   /  / \
                    ___:____\__\__\__________________________________________________________");
            Thread.Sleep(4000);
        }

        static void Main(string[] args)
        {
            WelcomeMessage();

            Console.WriteLine("-> Calculate ");

            bool calculatorOn = true;
            while (calculatorOn)
            {
                calculatorOn = CalculatorOn();
            }

            ExitAndThankYouMessage();
        }

    }
}
