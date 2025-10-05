using System;

static class Class9
{
	static public void afia()
	{
        int[] numbers = new int[10];
        int evenCount = 0, oddCount = 0;

        Console.WriteLine("Enter 10 integers:");

        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine($"\nTotal Even numbers: {evenCount}");
        Console.WriteLine($"Total Odd numbers: {oddCount}");
    }
}


