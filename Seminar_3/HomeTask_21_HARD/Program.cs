// =================Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в N-мерном пространстве.
// Сначала задается N с клавиатуры, потом задаются координаты точек.

int InputNumVectors()
{
    Console.WriteLine("Введите количество координатных осей > ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void InputKoord(int[] array, int length, char symbol)
{
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write($"Введите значение координаты точки {symbol} на {i + 1}-й оси > ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

void CountDistance(int[] pointA, int[] pointB, int length)
{
    double sum = 0;
    double var = 0;
    for (int i = 0; i < (length - 1); i++)
    {
        var = Math.Pow((pointB[i] - pointA[i]), 2);
        sum += var;
    }
    sum = Math.Sqrt(sum);
    Console.WriteLine($"Расстояние между точками А и В : {sum}");
}


char a = 'А';
char b = 'В';
int space = InputNumVectors();
int[] arrayA = new int[space];
int[] arrayB = new int[space];
InputKoord(arrayA, space, a);
InputKoord(arrayB, space, b);
CountDistance(arrayA, arrayB, space);