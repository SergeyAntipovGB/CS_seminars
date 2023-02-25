// Определяет, является ли введенное число четным

Console.Write("Введите число ");
double a = Convert.ToDouble(Console.ReadLine());
if ((a % 2) == 0)
    Console.WriteLine(a + " - число четное");
else
    Console.WriteLine(a + " - число нечетное");