using System;

static class Class3
{
	static public void afia()
	{
        Console.Write("Enter marks (0 - 100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 90 && marks <= 100)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 80 && marks <= 89)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 65 && marks <= 69)
        {
            Console.WriteLine("Grade: C");
        }
        else if (marks >= 50 && marks <= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else if (marks >= 0 && marks < 50)
        {
            Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter marks between 0 and 100.");
        }
    }
}


