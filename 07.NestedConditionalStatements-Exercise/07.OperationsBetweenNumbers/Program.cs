using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;
            string evenOrOdd = "";
            
            if (operation == "+")
            {
                result = firstNum + secondNum;
            }
            else if (operation == "-")
            {
                result = firstNum - secondNum;
            }
            else if (operation == "*")
            {
                result = firstNum * secondNum;
            }
            else if (operation == "/")
            {
                result = firstNum / secondNum;
            }
            else if (operation == "%")
            {
                result = firstNum % secondNum;
            }

            if (result % 2 == 0)
            {
                evenOrOdd = "even";
            }
            else
            {
                evenOrOdd = "odd";
            }

            if (operation == "+" || operation == "-" || operation == "*")
            {
                Console.WriteLine($"{firstNum} {operation} {secondNum} = {result} - {evenOrOdd}");
            }

            if (operation == "/" && secondNum == 0)
            {
                Console.WriteLine($"Cannot divide {firstNum} by zero");
            }
            else if (operation == "/")
            {
                Console.WriteLine($"{firstNum} / {secondNum} = {result:F2}");
            }

            if (operation == "%" && secondNum == 0)
            {
                Console.WriteLine($"Cannot divide {firstNum} by zero");
            }
            else if (operation == "%")
            {
                Console.WriteLine($"{firstNum} % {secondNum} = {result}");
            }
        }
    }
}
