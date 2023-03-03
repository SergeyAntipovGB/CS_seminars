// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("введите целое многозначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0) num = -num;
// if (num > 99)
// {
//     while (num > 999) num = num / 10;
//     num = num % 10;
//     Console.WriteLine("третья цифра - " + num);
// }
// else
//     Console.WriteLine("третьей цифры нет");

//////////////////////////////////////////////////////////

int Rnd(int minRand, int maxRand)   // Генерация случайного целого числа
{
    return new Random().Next(minRand, maxRand);
}

void FindTherdNumber(int inputNumber)     // Обработка входящего числа, поиск третьей цифры
{
    if (inputNumber < 0) inputNumber = -inputNumber;
    if (inputNumber > 99)
        {
        while (inputNumber > 999) inputNumber = inputNumber / 10;
        inputNumber = inputNumber % 10;
        Console.WriteLine("третья цифра - " + inputNumber);
        }
    else
        Console.WriteLine("третьей цифры нет");
}

int randomNumber = Rnd(1, 100000000);
Console.WriteLine("Случайное число " + randomNumber);
FindTherdNumber(randomNumber);