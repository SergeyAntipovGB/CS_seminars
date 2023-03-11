// ============================ Задача 38:
// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray(double[] myArray, int digits)
{
    double randDouble = 0;
    int randInt = 0;
    for (int i = 0; i < digits; i++)
    {
        randDouble = new Random().NextDouble();
        randInt = new Random().Next(-10000000, 10000001);
        myArray[i] = randDouble * randInt;
    }
    return myArray;
}

void PrintArray(double[] myArray)
{
    foreach (double item in myArray)
        Console.WriteLine(item);
}

double CointElement(double[] myArray)
{
    double max = myArray[0];
    double min = myArray[0];
    for (int i = 1; i < myArray.Length; i++)
    {
        if (max < myArray[i]) max = myArray[i];
        if (min > myArray[i]) min = myArray[i];
    }
    return max - min;
}


Console.Write("Введите количество элементов массива > ");
int howManyElements = int.Parse(Console.ReadLine());
double[] myArray = new double[howManyElements];
myArray = FillArray(myArray, howManyElements);
PrintArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами = {CointElement(myArray)}");