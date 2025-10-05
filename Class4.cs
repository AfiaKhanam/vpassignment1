using System;

public class Class4
{
	public Class4()
	{
        Console.Write("Enter a number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        
        for (int i= 1; i<= n; i++)
        {
            sum += i; 
        }

        Console.WriteLine($"The sum of natural numbers from 1 to {n} is: {sum}");
    }
}

