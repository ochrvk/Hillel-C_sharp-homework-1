using System;

internal class Program
{
    private static void Main(string[] args)
    {
        float firstNumber = 0;
        float secondNumber = 0;
        char operation = ' ';
        float result;


        Console.Write("Please, type the first number: ");
        firstNumber = float.Parse(Console.ReadLine());


        Console.Write("Please, type the second number: ");
        secondNumber = float.Parse(Console.ReadLine());

        Console.Write("Please, type operation: ");
        operation = Convert.ToChar(Console.Read());

        //Task solution using switch:

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);
                break;
            case '-':
                result = firstNumber - secondNumber;
                Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result);
                break;
            case '*':
                result = firstNumber * secondNumber;
                Console.WriteLine(firstNumber + " * " + secondNumber + " = " + result);
                break;
            case '/':
                result = firstNumber / secondNumber;
                Console.WriteLine(firstNumber + " / " + secondNumber + " = " + result);
                break;
            default:
                Console.WriteLine("Wrong operation!");
                break;
        }


        //Task solution using if-else:

        /*   if (operation == '+')
           {
               result = firstNumber + secondNumber;
               Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);
           }
           else if (operation == '-')
           {
               result = firstNumber - secondNumber;
               Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result);
           }
           else if (operation == '*')
           {
               result = firstNumber * secondNumber;
               Console.WriteLine(firstNumber + " * " + secondNumber + " = " + result);
           }
           else if (operation == '/')
           {
               result = firstNumber / secondNumber;
               Console.WriteLine(firstNumber + " / " + secondNumber + " = " + result);
           }
           else
           {
               Console.WriteLine("Wrong operation!");
           }*/
    }
}