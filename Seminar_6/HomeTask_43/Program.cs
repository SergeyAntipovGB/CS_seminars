// ==================================== Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
// b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputConst()
{
    double index = Convert.ToDouble(Console.ReadLine());
    return index; 
}

void FindPoint(double k1, double b1, double k2, double b2)
{
    bool point = false;
    double i = -900.0;
    while (i < 900.5)
    {
        if ((k1 * i + b1) == (k2 * i + b2))
        {
            Console.WriteLine($"Точка пересечения прямых имеет координаты ({i};{(k1 * i + b1)})");
            point = true;
            break;
        }
        i += 0.5;
    }
    if (point == false)
        Console.WriteLine("Прямые не пересекаются");
}


Console.Write("Введите значение константы k1 > ");
double k1 = InputConst();
Console.Write("Введите значение константы b1 > ");
double b1 = InputConst();
Console.Write("Введите значение константы k2 > ");
double k2 = InputConst();
Console.Write("Введите значение константы b2 > ");
double b2 = InputConst();
FindPoint(k1, b1, k2, b2);
