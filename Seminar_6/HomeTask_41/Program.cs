// ================================ Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int[] myArray, int digits)
{
    for (int i = 0; i < digits; i++)
    {
        Console.Write($"Введите {i + 1}-е число > ");
        myArray[i] = int.Parse(Console.ReadLine());
    }
    return myArray;
}

void PrintArray(int[] myArray)
{
    foreach (int item in myArray)
        Console.Write($"{item}, ");
}

int CointPositiveElements(int[] myArray)
{
    int sum = 0;
    foreach (var item in myArray)
        if (item > 0) sum++;
    return sum;
}


Console.Write("Введите количество элементов массива > ");
int howManyElements = int.Parse(Console.ReadLine());
int[] myArray = new int[howManyElements];
myArray = FillArray(myArray, howManyElements);
PrintArray(myArray);
Console.WriteLine($"-> {CointPositiveElements(myArray)}");