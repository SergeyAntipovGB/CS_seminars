// ================================ Задача HARD STAT необязательная:
// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс,
// минимальный элемент и его индекс, среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива ,
// возможно придется кое-что для этого дополнительно выполнить.

int[] FillArray(int[] myArray, int digits)
{
    for (int i = 0; i < digits; i++)
         myArray[i] = new Random().Next(-999, 1000);
    return myArray;
}

void PrintArray(int[] myArray)
{
    foreach (int item in myArray)
        Console.Write($"{item} ");
    Console.WriteLine();
}

void Calculate(int[] myArray, double[] answersNumber)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (answersNumber[0] < myArray[i])
        {
            answersNumber[0] = myArray[i];
            answersNumber[1] = i;
        }
        if (answersNumber[2] > myArray[i])
        {
            answersNumber[2] = myArray[i];
            answersNumber[3] = i;
        }
        answersNumber[4] += myArray[i];
    }
    answersNumber[4] /= myArray.Length;
    if (myArray.Length % 2 != 0)
        answersNumber[5] = myArray[myArray.Length / 2];
    else
        answersNumber[5] = (myArray[myArray.Length / 2 - 1] + myArray[myArray.Length / 2]) / 2;
}

void PrintAnswer(double[] answersNumber, string[] answersString)
{
    for (int i = 0; i < 6; i++)
        Console.WriteLine(answersString[i] + answersNumber[i]);
}


Console.Write("Введите количество элементов массива > ");
int howManyElements = int.Parse(Console.ReadLine());
int[] myArray = new int[howManyElements];
myArray = FillArray(myArray, howManyElements);
double[] answersNumber = {myArray[0], 0, myArray[0], 0, 0, 0};
string[] answersString = {"Максимальный элемент = ", "Индекс максимального элемента = ",
        "Минимальный элемент = ", "Индекс минимального элемента = ",
        "Среднее арифметическое всех элементов = ", "Медианное значение массива = "};

PrintArray(myArray);
Calculate(myArray, answersNumber);
PrintAnswer(answersNumber, answersString);