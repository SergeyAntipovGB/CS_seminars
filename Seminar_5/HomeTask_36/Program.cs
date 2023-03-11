// ============================== Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int[] myArray, int digits)
{
    for (int i = 0; i < digits; i++)
        myArray[i] = new Random().Next(-99, 100);
    return myArray;
}

void PrintArray(int[] myArray)
{
    foreach (int item in myArray)
        Console.Write($"{item} ");
}

int CointOddElements(int[] myArray)
{
    int sum = 0;
    for (int i = 1; i < myArray.Length; i = i + 2)
        sum += myArray[i];
    return sum;
}


Console.Write("Введите количество элементов массива > ");
int howManyElements = int.Parse(Console.ReadLine());
int[] myArray = new int[howManyElements];
myArray = FillArray(myArray, howManyElements);
PrintArray(myArray);
Console.WriteLine($"-> {CointOddElements(myArray)}");