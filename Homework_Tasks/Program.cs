/*
1.	Задача 2: Напишите программу, которая на вход принимает 
    два числа и выдаёт, какое число большее, а какое меньшее.
-------------------------------------------------------------
*/
Console.WriteLine("Input any two number:");
Console.WriteLine("---");

Console.Write("Input the first number => ");
double number_1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
Console.Write("Input the second number => ");
double number_2 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

if (number_1 > number_2)
{
    Console.WriteLine($"First number = {number_1} > Second = {number_2}");
}
else
{
    Console.WriteLine($"Second number = {number_2} > First = {number_1}");
}