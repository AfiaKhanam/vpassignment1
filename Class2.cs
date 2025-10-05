using System;

public class Class2
{
	public Class2()
	{
        double num2, num3, result = 0;
        char operation;

        Console.WriteLine("=== Simple Calculator ===");

        
        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        
        Console.Write("Enter second number: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        
        switch (operation)
        {
            case '+':
                result = num2 + num3;
                Console.WriteLine($"Result: {num2} + {num3} = {result}");
                break;

            case '-':
                result = num2 - num3;
                Console.WriteLine($"Result: {num2} - {num3} = {result}");
                break;

            case '*':
                result = num2 * num3;
                Console.WriteLine($"Result: {num2} * {num3} = {result}");
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num2 / num3;
                    Console.WriteLine($"Result: {num2} / {num3} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed!");
                }
                break;

            default:
                Console.WriteLine("Invalid operation. Please use +, -, *, or /.");
                break;
        }
    }
}

