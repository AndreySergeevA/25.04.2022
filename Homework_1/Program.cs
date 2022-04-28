//Напишите программу, которая на вход принимает
//два числа и выдает, какое число болешее, а 
//какое меньшее.

Console.WriteLine("Введите два целых числа");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

int max = a;
int min = a;
if(a < b) max = b;
if(a > b) min = b;

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);