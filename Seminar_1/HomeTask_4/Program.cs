// Принимает на вход три числа и выдаёт максимальное из них

Console.WriteLine("Введите три числа:");
Console.Write("а = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("c = ");
double c = Convert.ToDouble(Console.ReadLine());

double max = a;
if (max < b)
    max = b;
if (max < c)
    max = c;
Console.WriteLine("наибольшее из трёх чисел: " + max);