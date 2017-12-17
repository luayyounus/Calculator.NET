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

            Calculate(userInput);
            return true;
        }

        public static void Calculate(string input)
        {
            char[] operations = new char[] {'+', '-'};
            int[] numbersToBeCalculated = new int[]{2,4,1} ;

            if (operations.Length >= numbersToBeCalculated.Length)
            {
                Console.WriteLine("Wrong entry. Calculate again using one or more operations");
                Calculate(Console.ReadLine());
            }

            int result = numbersToBeCalculated[0];
            int j = 0;
            for (var i = 1; i < numbersToBeCalculated.Length; i++)
            {
                switch (operations[j])
                {
                    case '+':
                    {
                        result += numbersToBeCalculated[i];
                        break;
                    }
                    case '-':
                    {
                        result -= numbersToBeCalculated[i];
                        break;
                    }
                    case '*':
                    {
                        result *= numbersToBeCalculated[i];
                        break;
                    }
                    case '/':
                    {
                        result /= numbersToBeCalculated[i];
                        break;
                    }
                    default:
                        break;
                }
                j++;
            }
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("\nType 'Exit' to leave :( Or try another calculation :)\n");
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
