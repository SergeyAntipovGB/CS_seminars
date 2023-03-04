//========================== Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void InputNum(int[] array)
{ 
    Console.Write("Введите значение координаты x > ");
    array[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение координаты y > ");
    array[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение координаты z > ");
    array[2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

void Distance(int[] pointA, int[] pointB)
{
    double sum = 0;
    double var = 0;
    for (int i=0; i<3; i++)
    {
        var = Math.Pow((pointB[i] - pointA[i]), 2);
        sum += var;
    }
    sum = Math.Sqrt(sum);
    Console.WriteLine($"Расстояние между точками А и В : {sum}");
}


int[] a = new int[3];
int[] b = new int[3];
InputNum(a);
InputNum(b);
Distance(a, b);