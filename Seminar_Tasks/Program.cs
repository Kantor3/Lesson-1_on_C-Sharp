/*
1.	Задача-1. Написать программу, которая возводит 
    в квадрат введенное пользователем число и выдает результат.
---------------------------------------------------------------
Console.Write("Input any integer number:");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;
int square_via_math = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Squere of {number} is {square}");
Console.WriteLine($"Squere of {number} via math is {square_via_math}");
*/


/*
2.	Задача-2. Напишите программу, которая на вход принимает два числа 
    и проверяет, является ли первое число квадратом второго
*/
Console.WriteLine("Input any two numbers.");

Console.Write("First: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Second: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if (number1 == Math.Pow(number2, 2))
{
    Console.WriteLine($"First number {number1} is the square of the second {number2}");
}
else
{
    Console.WriteLine($"First number {number1} is not a square of the second {number2}");
}

