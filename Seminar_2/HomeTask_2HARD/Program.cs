﻿//                 Задача необязательная 2:
// В институте биоинформатики по офису передвигается робот.
// Недавно студенты из группы программистов написали для него программу,
// по которой робот, когда заходит в комнату, считает количество
// программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно
// использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число
// n (неотрицательное), выводящее это число в консоль вместе с правильным
// образом изменённым словом "программист", для того, чтобы робот мог
// нормально общаться с людьми, например: 1 программист, 2 программиста,
// 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша
// программа правильно обработает все случаи, как минимум до 1000 человек.

// Console.Write("Введите количество человек в комнате : ");
// int programmers = Convert.ToInt32(Console.ReadLine());
// int div = 1; //целочисленный остаток
// string index; //окончание слова

// if (programmers < 0) Console.WriteLine("Неверное число!");
// else 
// {
//     if ((programmers < 15) && (programmers > 10)) index = "ов";
//     else
//     {
//         div = programmers % 10;
//         if (div == 1) index = "";
//         else if ((div > 1) && (div < 5)) index = "а";
//             else index = "ов";
//     }
//     Console.WriteLine($"В помещении находится {programmers} программист{index}");
// }

////////////////////////////////////////////////////////////

int Rnd(int minRand, int maxRand)   // Генерация случайного целого числа
{
    return new Random().Next(minRand, maxRand);
}

string Progs(int coint)     // Подбор окончания слова
{
    string index = "NO"; //окончание слова
    int div = 1; //целочисленный остаток
    if ((coint < 15) && (coint > 10)) index = "ов";
    else
    {
        div = coint % 10;
        if (div == 1) index = "";
        else if ((div > 1) && (div < 5)) index = "а";
            else index = "ов";
    }
    return index;
}

int programmers = Rnd(0, 1001);
Console.WriteLine($"В помещении находится {programmers} программист{Progs(programmers)}");