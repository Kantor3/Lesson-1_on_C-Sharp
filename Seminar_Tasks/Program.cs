/*
1.	Задача-1. Написать программу, которая возводит 
в квадрат введенное пользователем число и выдает результат.
*/
Console.Write("Input any integer number:");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;
int square_via_math = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Squere of {number} is {square}");
Console.WriteLine($"Squere of {number} via math is {square_via_math}");