// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100, 1000);
// Console.WriteLine("Входное число " + num);
// num = num / 10 % 10;
// Console.WriteLine("Вторая цифра числа равна " + num);

///////////////////////////////////////////////////////

int Rnd(int minRand, int maxRand)   // Генерация случайного целого числа
{
    return new Random().Next(minRand, maxRand);
}

int FindNumber(int inputNumber)     // Вычисление второй цифры трёхзначного числа
{
    return inputNumber / 10 % 10;
}

int number = Rnd(100, 1000);
Console.Write("Для трёхзначного числа " + number);
Console.WriteLine(" вторая цифра равна " + FindNumber(number));
