// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber()
{
    Console.Write("Введите целое число > ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintSumDigits(int number)
{
    int sum = 0;
    int temp = number;
    while (temp >= 1)
    {
        sum += temp % 10;
        temp /= 10;
    }
    Console.WriteLine($"Сумма всех цифр числа {number} равна {sum}");
}


int num = InputNumber();
PrintSumDigits(num);