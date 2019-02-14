using System;
using System.Linq;

namespace Calculator
{
    internal class Program
    {
        
        private static readonly string[] operations = { "+", "-", "*", "/", "^", "%" };

        
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                double firstNumber = SetNumber("Type you first number : ");
                double secondNumber = SetNumber("Type you second number: ");
                string stringOperation = SetOperation("Enter the operation + (addition), - (subtraction), * (multiplication), / (division), ^ (exponent) or % (modulo) :");

                double result = Calculate(firstNumber, stringOperation, secondNumber);
    
                Console.WriteLine("Result of {0} {1} {2} = {3}", firstNumber, stringOperation, secondNumber, result);
                Console.ReadKey();
            }
            else
            {
                int i = 0;
                string stringArgsOperation = "";
                
                double firstArgsNumber = 0;
                double secondArgsNumber = 0;
                foreach(string arguments in args)
                {    
                    if (i == 0)
                    {
                       firstArgsNumber = SetArgsNumber(arguments);
                    }
                    else if (i == 1)
                    {
                        stringArgsOperation = SetArgsOperation(arguments);
                    }
                    else if (i == 2)
                    {
                        secondArgsNumber = SetArgsNumber(arguments); 
                    }
                    i++;
                }

                double resultArgs = CalculateArgs(firstArgsNumber, stringArgsOperation, secondArgsNumber);
                Console.WriteLine("Result of {0} {1} {2} = {3}", firstArgsNumber, stringArgsOperation, secondArgsNumber, resultArgs);
                Console.ReadKey();
                
            }
        }
    
        
        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return double.Parse(tempInput);
        }
        
        private static double SetArgsNumber(string arguments)
        {
            double parse;
            string tempInput = arguments;
            while (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                break;
            }
            return double.Parse(tempInput);
        }
    
        private static bool IsValidOperation(string input)
        {
            return operations.Contains(input);
        }
    
        private static string SetOperation(string outputText)
        {
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return tempInput;
        }
        
        private static string SetArgsOperation(string arguments)
        {
            string tempInput = arguments;
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect Operation !");
                break;
            }
            return tempInput;
        }

        private static double CalculateArgs(double firstArgsNumber, string stringArgsOperation, double secondArgsNumber)
        {
            double resultArgs = 0;
            switch (stringArgsOperation)
            {
                case "+":
                case "addition":
                    resultArgs = firstArgsNumber + secondArgsNumber;
                    break;
                case "-":
                case "subtraction":
                    resultArgs = firstArgsNumber - secondArgsNumber;
                    break;
                case "*":
                case "multiplication":
                    resultArgs = firstArgsNumber * secondArgsNumber;
                    break;
                case "/":
                case "division":
                    resultArgs = firstArgsNumber / secondArgsNumber;
                    break;
                case "^":
                case "exponent":
                    resultArgs = Math.Pow(firstArgsNumber, secondArgsNumber);
                    break;
                case "%":
                case "modulo":
                    resultArgs = firstArgsNumber % secondArgsNumber;
                    break;
            }

            return resultArgs;
            
        }
        
        private static double Calculate(double firstNumber, string stringOperation, double secondNumber)
        {
            double result = 0;
            switch (stringOperation)
            {
                case "+":
                case "addition":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                case "subtraction":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                case "multiplication":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                case "division":
                    result = firstNumber / secondNumber;
                    break;
                case "^":
                case "exponent":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                case "%":
                case "modulo":
                    result = firstNumber % secondNumber;
                    break;
            }

            return result;
            
        }
      
    }
}