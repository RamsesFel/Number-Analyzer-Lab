using System.Reflection.Metadata.Ecma335;
bool runProgram = true;
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
while (runProgram)
{
    Console.WriteLine("Enter a number between 1 and 100");
    int input = int.Parse(Console.ReadLine());

    if (input % 2 == 1 && input < 60)
    {
        Console.WriteLine(input + " is odd and is less than 60");
    }
    else if (input % 2 == 0 && 2 <= input && input <= 24)
    {
        Console.WriteLine(input + " is even and less than 25");
    }
    else if (input % 2 == 0 && input >= 26 && input <= 60)
    {
        Console.WriteLine(input + " is even and greater than 60");
    }
    else if (input % 2 == 0 && input > 60)
    {
        Console.WriteLine(input + " is even and greater than 60");
    }
    else if (input % 2 == 1 && input > 60)
    {
        Console.WriteLine(input + " is odd and greater than 60");
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
    bool repeat = true;
    while (repeat)
    {
        Console.WriteLine($"Would you like to enter another number {name}? y/n");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            repeat = false;
        }
        else if (answer == "n")
        {
            runProgram = false;
            repeat = false;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}