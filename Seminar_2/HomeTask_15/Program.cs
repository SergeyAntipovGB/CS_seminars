// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите порядковый номер дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if ((day < 1) || (day > 7)) Console.WriteLine("такого номера нет в неделе!");
// else
// {
//     if ((day == 6) || (day == 7)) Console.WriteLine("это выходной день!");
//     else Console.WriteLine("Это не выходной день!");
// }

////////////////////////////////////////////////

int DayOfWeek()     // Ввод порядкового номера дня недели с проверкой правильности
{
    int day=-1;
    bool index = false;
    while  (index == false)
    {
        Console.Write("Введите порядковый номер дня недели: ");
        day = Convert.ToInt32(Console.ReadLine());
        if ((day < 1) || (day > 7)) Console.WriteLine("такого номера дня нет в неделе!");
        else index = true;
    }
    return day;   
}

void WhatADay(int numberDay)        // Вывод на консоль соответствующего дня
{
    if ((numberDay == 6) || (numberDay == 7)) Console.WriteLine("это выходной день!");
    else Console.WriteLine("Это не выходной день!");
}

WhatADay(DayOfWeek());