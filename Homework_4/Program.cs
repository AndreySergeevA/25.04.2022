//Напишите программу, которая на вход принимает
//число (N), а на выходе показывает все четные
//числа от 1 до N.


Console.WriteLine("Введите число -> ");
int N = int.Parse(Console.ReadLine());
int count = 1;
Console.WriteLine("Вывод чисел");
while (count <= N)
{
    if(count % 2 == 0)
    {
        if (count == N - 1)
        {
           Console.Write(count + ". ");   
        }
        else
        {
            Console.Write(count + ", ");
        }
    }
    count++;
}