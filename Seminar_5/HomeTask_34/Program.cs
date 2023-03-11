// ========================= Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int[] myArray, int digits)
{
    for (int i = 0; i < digits; i++)
         myArray[i] = new Random().Next(100, 1000);
    return myArray;
}

void PrintArray(int[] myArray)
{
    foreach (int item in myArray)
        Console.Write($"{item} ");
}

int CointEvenElements(int[] myArray)
{
    int sum = 0;
    foreach (var item in myArray)
        if (item % 2 == 0) sum++;
    return sum;
}


Console.Write("Введите количество элементов массива > ");
int howManyElements = int.Parse(Console.ReadLine());
int[] myArray = new int[howManyElements];
myArray = FillArray(myArray, howManyElements);
PrintArray(myArray);
Console.WriteLine($"-> {CointEvenElements(myArray)}");