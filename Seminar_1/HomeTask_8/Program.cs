// Принимает на вход число N, а на выходе показывает все четные числа от 1 до N

Console.Write("Введите целое число N большее единицы ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (n > 1)
{
    while (count <= n)
    {
        if ((count % 2) == 0)
            Console.Write(count + ", ");
        count++;
    }
}
else
    Console.WriteLine("введено неверное число");
Console.WriteLine();