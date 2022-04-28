Console.WriteLine("Введите число -> ");
int num = int.Parse(Console.ReadLine());
int count = -num;
Console.WriteLine("Вывод чисел");
while (count <= num)
{
    Console.Write(count + ", ");
    count++;
}