using System;

public class Class7
{
	public Class7()
	{
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reversed = 0;

        int temp = num; 

        while (num > 0)
        {
            int digit = num % 10;         
            reversed = (reversed * 10) + digit; 
            num = num / 10;               
        }

        Console.WriteLine($"The reverse of {temp} is: {reversed}");
    }
}
}
