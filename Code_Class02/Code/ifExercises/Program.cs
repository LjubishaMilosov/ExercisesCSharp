//Get an input number from the console
//Print all numbers from 1 up to that number
//Get another input number from the console
//Print all numbers starting from that number up to 1

Console.WriteLine("Enter a number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

if (firstSuccess)
{
    for (int i = 1; i <= firstNumber; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine("Enter another number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);
if (secondSuccess)
{
    for (int i = secondNumber; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}


//Get an input number from the console
//Print all even numbers starting from 2
//Get another input number from the console
//Print all odd numbers starting from 1

Console.WriteLine("Enter a number:");
bool thirdSuccess = int.TryParse(Console.ReadLine(), out int thirdNumber);
if (thirdSuccess)
{
    for (int i = 2; i <= thirdNumber; i += 2)
    {
        Console.WriteLine(i);
    }
    for (int i = 2; i <= thirdNumber; i++) //second way, with the classic check for even numbers
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
