// Принимает на вход два числа и выдаёт, какое большее, а какое меньшее

Console.Write("Введите два числа: а = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("и b = ");
double b = Convert.ToDouble(Console.ReadLine());

if (a < b)
    Console.WriteLine("число " + b + " больше числа " + a);
else
{
    if (a > b)
        Console.WriteLine("число " + a + " больше числа " + b);
    else
        Console.WriteLine("числа равны");
}