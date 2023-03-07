// Задача 25: Напишите цикл, который принимает на вход два
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void InputTwoNumbers(int[] numAB)
{
    Console.Write("Введите число А > ");
    numAB[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение степени B > ");
    numAB[1] = Convert.ToInt32(Console.ReadLine());
}

void CointAToBPower(int[] numAB)
{
    int pow = 1;
    for (int i = 0; i < numAB[1]; i++)
    {
        pow *= numAB[0];
    }
    Console.WriteLine($"{numAB[0]}^{numAB[1]} = {pow}");
}


int[] numAB = {0, 0};
InputTwoNumbers(numAB);
CointAToBPower(numAB);