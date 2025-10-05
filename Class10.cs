using System;

static class Class10
{
	static public void afia()
	{
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 integers:");

        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        Console.Write("\nEnter a number to search: ");
        int searchNum = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        int position = -1;

        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNum)
            {
                found = true;
                position = i; 
                break; 
            }
        }

        if (found)
        {
            Console.WriteLine($"{searchNum} exists in the array at position {position + 1} (index {position}).");
        }
        else
        {
            Console.WriteLine($"{searchNum} does not exist in the array.");
        }
    }
}


