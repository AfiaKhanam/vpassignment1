using System;

static class Class6
{
	static public void afia()
	{
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        long factorial = 1;

        while (i <= n)
        {
            factorial *= i; 
            i++;
        }

        Console.WriteLine($"Factorial of {n} is: {factorial}");
    }
}


