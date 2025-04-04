
using System.Diagnostics.Metrics;
using System;

//Task 1
//Create new console application called“RealCalculator” that takes two numbers from the input
//and asks what operation would the user want to be done ( +, - , * , / ).
//Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25


Console.WriteLine("Enter the First number: ");
bool firstNumberSuccess = double.TryParse(Console.ReadLine(), out double firstNumber);

Console.WriteLine("Enter the Second number: ");
bool secondNumberSuccess = double.TryParse(Console.ReadLine(), out double secondNumber);

Console.WriteLine("Enter the Operation: Choose +, - , * , / ");
string operation = Console.ReadLine();
double result = 0;

if (firstNumberSuccess && secondNumberSuccess)
{
    switch (operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            Console.WriteLine($"The result is: {result}");
            break;
        case "-":
            result = firstNumber - secondNumber;
            Console.WriteLine($"The result is: {result}");
            break;
        case "*":
            result = firstNumber * secondNumber;
            Console.WriteLine($"The result is: {result}");
            break;
        case "/":
            if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            break;
        default:
            Console.WriteLine("Invalid operation. Please choose +, - , * , / .");
            break;
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter valid numbers.");
    return;
}