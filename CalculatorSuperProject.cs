//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace helloworld
//{
//    internal class calculatorsuperproject
//    {
//        class profisionalcalculator
//        {
//            static void Main3(string[] args)
//            {
//                //22:33 = time making a calculator - c# project | coffencode// let's started
//                Console.WriteLine("Welcome to my calculator" + Environment.NewLine);
//                //console.writeline();

//                bool isrpeating = true;

//                while (isrpeating)
//                {
//                    int firstNumber = readIntFromConsole("Enter your first number: ");

//                    Console.WriteLine("Now choose your operator");
//                    Console.WriteLine("1. plus (+)");
//                    Console.WriteLine("2. minus (-)");
//                    Console.WriteLine("3. divide (/)");
//                    Console.WriteLine("4. multiply (*)" + Environment.NewLine);

//                    string operatorInput = readStringFromConsole("Enter your operator: ");
//                    int secondNumber = readIntFromConsole("Enter your second number: ");

//                    double result = 0.0;
//                    bool inputCorrect = true; // assta verifica daca operatorul este pus corect 

//                    if (checkCondition("+", "plus", "1", operatorInput))
//                    {
//                        result = firstNumber + secondNumber;
//                        operatorInput = "+";
//                    }
//                    else if (checkCondition("-", "minus", "2", operatorInput))
//                    {
//                        result = firstNumber - secondNumber;
//                        operatorInput = "-";
//                    }
//                    else if (checkCondition("/", "divide", "3", operatorInput))
//                    {
//                        result = (double)firstNumber / secondNumber;
//                        operatorInput = "/";
//                    }
//                    else if (checkCondition("*", "multiply", "4", operatorInput))
//                    {
//                        result = firstNumber * secondNumber;
//                        operatorInput = "*";
//                    }
//                    else
//                    {
//                        inputCorrect = false; // daca nici una de sus nu este adevarat o sa fie false
//                    }

//                    if (inputCorrect)
//                        Console.WriteLine(Environment.NewLine + "The result of " + firstNumber + " " + operatorInput + " " + secondNumber + " = " + result);   // ?? nu am vazut pana la urma
//                    else
//                        Console.WriteLine(Environment.NewLine + "You have entered an incorrect operator.");

//                    string repeatInput = readStringFromConsole("Do you want to calculate something else?: ");
//                    isrpeating = repeatInput.ToLower().Contains("y");
//                }

//                Console.WriteLine("Thank you for using this calculator.");

//                Console.ReadLine();
//            }
//            public static string readStringFromConsole(string message)
//            {
//                Console.WriteLine(message);
//                return Console.ReadLine();
//            }
//            public static int readIntFromConsole(string message)
//            {
//                string output = readStringFromConsole(message);
//                return Convert.ToInt32(output);
//            }
//            public static bool checkCondition(string symbol, string word, string number, string comparison)
//            {
//                if (comparison.Contains(symbol) || comparison.Contains(word) || comparison.Contains(number))
//                    return true;

//                return false;
//            }
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calc
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to my calculator" + Environment.NewLine);
//            //Console.WriteLine();

//            bool isRepeating = true;

//            while (isRepeating)
//            {
//                int firstNumber = readIntFromConsole("Enter your first number: ");

//                Console.WriteLine("Now choose your operator");
//                Console.WriteLine("1. plus (+)");
//                Console.WriteLine("2. minus (-)");
//                Console.WriteLine("3. divide (/)");
//                Console.WriteLine("4. multiply (*)" + Environment.NewLine);

//                string operatorInput = readStringFromConsole("Enter your operator: ");
//                int secondNumber = readIntFromConsole("Enter your second number: ");

//                double result = 0.0;
//                bool inputCorrect = true;

//                if (checkConditions("+", "plus", "1", operatorInput))
//                {
//                    result = firstNumber + secondNumber;
//                    operatorInput = "+";
//                }
//                else if (checkConditions("-", "minus", "2", operatorInput))
//                {
//                    result = firstNumber - secondNumber;
//                    operatorInput = "-";
//                }
//                else if (checkConditions("/", "divide", "3", operatorInput))
//                {
//                    result = (double)firstNumber / secondNumber;
//                    operatorInput = "/";
//                }
//                else if (checkConditions("*", "multiply", "4", operatorInput))
//                {
//                    result = firstNumber * secondNumber;
//                    operatorInput = "*";
//                }
//                else
//                {
//                    inputCorrect = false;
//                }

//                if (inputCorrect)
//                    Console.WriteLine(Environment.NewLine + "The result of " + firstNumber + " " + operatorInput + " " + secondNumber + " is: " + result);
//                else
//                    Console.WriteLine(Environment.NewLine + "You have entered an incorrect operator.");

//                string repeatInput = readStringFromConsole("Do you want to calculate something else?: ");
//                isRepeating = repeatInput.ToLower().Contains("y");
//            }

//            Console.WriteLine("Thank you for using this calculator.");

//            Console.ReadLine();
//        }
//        public static string readStringFromConsole(string message) 
//        {
//            Console.Write(message);
//            return Console.ReadLine(); // ce introduci de la tastatura el iti returneaza 
//        }
//        public static int readIntFromConsole(string message) // Enter your first number //
//        {
//            string output = readStringFromConsole(message);
//            return Convert.ToInt32(output);
//        }
//        public static bool checkConditions(string symbol, string word, string number, string comparison)
//        {
//            if (comparison.Contains(symbol) || (comparison.Contains(word) || (comparison.Contains(number))))
//                return true;

//            return false;
//        }
//    }
//}




















//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calc
//{
//    internal class Calculator1
//    {
//        class Calc
//        {
//            static void Main3(string[] args)
//            {
//                Console.WriteLine("Welcome to my calculator");
//                Console.WriteLine();

//                Console.Write/* */("Enter your first number: ");
//                string firstNumberInput = Console.ReadLine();
//                int firstNumber = Convert.ToInt32(firstNumberInput);
//                //Console.ReadLine();

//                Console.Write/* */("Enter your Operator: ");
//                string operatorInput = Console.ReadLine();

//                Console.Write/* */("Enter your second number: ");
//                string SecondNumberInput = Console.ReadLine();
//                int SecondNumber = Convert.ToInt32(SecondNumberInput);

//                double result = 0.0;

//                if (operatorInput.Contains("+"))
//                {
//                    result = firstNumber + SecondNumber;
//                }
//                else if (operatorInput.Contains("-"))
//                {
//                    result = firstNumber - SecondNumber;
//                }
//                else if (operatorInput.Contains("/"))
//                {
//                    result = firstNumber / SecondNumber;
//                }
//                else if (operatorInput.Contains("*"))
//                {
//                    result = firstNumber * SecondNumber;
//                }

//                Console.WriteLine(Environment.NewLine + "The result of " + firstNumber + " " + operatorInput + " " + SecondNumber + " is: " + result);

//                Console.ReadLine();
//            }
//        }
//    }
//}
