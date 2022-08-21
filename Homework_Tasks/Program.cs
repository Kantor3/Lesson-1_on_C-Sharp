/*
1.	Задача 2: Напишите программу, которая на вход принимает 
    два числа и выдаёт, какое число большее, а какое меньшее.
-------------------------------------------------------------
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
*/


/*
2.	Задача 4: Напишите программу, которая принимает на вход 
    три числа и выдаёт максимальное из этих чисел.
    расширил до введения заданного количества любых чисел (но не более 10)
--------------------------------------------------------------------------
*/
Console.Write("Input the number of numbers to compare, but no more than 10: ");
int count_max   = 10;
int count       = Math.Min(count_max, Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("---");

List<double> numsList = new List<double>();

for (int i = 0; i < count; i++)
{
    Console.Write($"Enter number № {i+1} => ");
    numsList.Add(Convert.ToDouble(Console.ReadLine().Replace(".", ",")));
}

double number_max = numsList[0];
foreach (var el in numsList)
    number_max = Math.Max(number_max, el);

Console.WriteLine("Numbers are entered:");
numsList.ForEach(i => { Console.Write($"{i}; "); });
Console.WriteLine($"The maximum of them => {number_max}");



