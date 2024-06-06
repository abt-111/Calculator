using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        double firstOperand = 0;
        double secondOperand = 0;
        string operation = "";

        Console.WriteLine("first operand: ");
        firstOperand = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("second operand: ");
        secondOperand = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("which operation you choose: ");
        operation = Console.ReadLine();

        Console.WriteLine(firstOperand + " + " + secondOperand + " = " + Add(firstOperand, secondOperand));
    }

    public static double Add(double x, double y)
    {
        return x + y;
    }
}