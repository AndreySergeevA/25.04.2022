//Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел

Console.WriteLine("Введите три целых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;
if(a < b) max = b;
if(b < c) max = c;

Console.WriteLine("Наибольшее число");
Console.WriteLine(max);


