//================================== Задача 27. - HARD необязательная
// Напишите программу, которая принимает на вход целое или дробное число
// и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

decimal RevertNum(decimal num)   // Приводит десятичную дробь к целому числу
{
    while (num % 1 != 0)
        num *= 10;
    return num;
}

void HowManyDigits(decimal num)
{
    int digits = 1;
    if (num < 0) num = -num;
    if (num % 1 != 0) num = RevertNum(num);
    while (num > 9)
    {
        num = (num - num % 10) / 10;
        digits++;
    }
    Console.WriteLine($"Количество цифр = {digits}");
}


Console.Write("Введите любое число > ");
decimal num = Convert.ToDecimal(Console.ReadLine());
HowManyDigits(num);