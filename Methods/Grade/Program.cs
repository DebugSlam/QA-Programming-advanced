﻿
static void Grade(double number)
{
    if (number >= 2 && number <3)
    {
        Console.WriteLine("Fail");

    }

    else if (number >= 3 && number < 3.5)
        {
        Console.WriteLine("Average");

    }

    else if (number >= 3.5 && number < 4.5)
    {
        Console.WriteLine("Good");

    }
    else if (number >= 4.5 && number < 5.5)
    {
        Console.WriteLine("Very good");

    }
    else if (number >= 5.5 && number <= 6)
    {
        Console.WriteLine("Excellent");

    }
}

double GradeInNumber= double.Parse(Console.ReadLine());

Grade(GradeInNumber);
