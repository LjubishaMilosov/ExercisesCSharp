//Create two variables and initialize them with a keyboard input
//Write code that can test which number is larger
//Write code that can test the numbers whether they are even or odd
//Output:
//Write in the console: The larger number from the two is #Number#
//After that write: And the number is even/odd

Console.WriteLine("Please enter the first number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Please enter the second number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

if (firstSuccess && secondSuccess)
{
    if (firstNumber % 2 == 0)
    {
        Console.WriteLine($"{firstNumber} is even");
    }
    else
    {
        Console.WriteLine($"{firstNumber} is odd");
    }
    if (secondNumber % 2 == 0)
    {
        Console.WriteLine($"{secondNumber} is even");
    }
    else
    {
        Console.WriteLine($"{secondNumber} is odd");
    }
    if (firstNumber > secondNumber)
    {
        Console.WriteLine($"The larger number from the two is {firstNumber}");
    }
    else if (secondNumber > firstNumber)
    {
        Console.WriteLine($"The larger number from the two is {secondNumber}");
    }
    else
    {
        Console.WriteLine("Both numbers are equal.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter valid numbers.");
}