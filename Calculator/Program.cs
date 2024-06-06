using System;
using System.Collections.Generic;
using System.Reflection;

class MainClass
{
    public static void Main(string[] args)
    {
        double firstOperand = 0;
        double secondOperand = 0;
        string operation = "";

        Console.Write("first operand: ");
        firstOperand = Convert.ToDouble(Console.ReadLine());

        Console.Write("second operand: ");
        secondOperand = Convert.ToDouble(Console.ReadLine());

        Console.Write("which operation you choose (add, sub, multi, div, mod): ");
        operation = Console.ReadLine();

        switch(operation)
        {
            case "add":
                Add(firstOperand, secondOperand);
                break;
            case "sub":
                Substract(firstOperand, secondOperand);
                break;
            case "multi":
                Multiply(firstOperand, secondOperand);
                break;
            case "div":
                Divide(firstOperand, secondOperand);
                break;
            case "mod":
                Modulo((int)firstOperand, (int)secondOperand);
                break;
            default:
                Console.WriteLine("Unknown operation " + operation);
                break;
        }
    }

    public static void Add(double x, double y)
    {
        Console.WriteLine(x + " + " + y + " = " + (x + y));
    }

    public static void Substract(double x, double y)
    {
        Console.WriteLine(x + " - " + y + " = " + (x - y));
    }

    public static void Multiply(double x, double y)
    {
        Console.WriteLine(x + " * " + y + " = " + (x * y));
    }

    public static void Divide(double x, double y)
    {
        if(y == 0)
        {
            Console.WriteLine("Pas de diviseur égale à 0 petit malin");
        }
        else
        {
            Console.WriteLine(x + " / " + y + " = " + (x / y));
        }
    }

    public static void Modulo(int x, int y)
    {
        if (y == 0)
        {
            Console.WriteLine("Pas de diviseur égale à 0 petit malin");
        }
        else
        {
            Console.WriteLine(x + " % " + y + " = " + (x % y));
        }
    }
}