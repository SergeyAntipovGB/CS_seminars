//====================== Задача 23
// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNumber()
{
    int inpNum = -1;
    bool crash = true;
    while (crash == true)
    {
        Console.Write("Введите целое положительное число N > ");
        inpNum = Convert.ToInt32(Console.ReadLine());
        if ((inpNum > 0) && (inpNum < 1250))
            crash = false;
        else
            Console.WriteLine("Неподходящее число !");
    }
    return inpNum;
}   

void Table(int num)
{
    Console.Write($"{num} -> ");
    for (int i = 1; i <= num; i++)
        Console.Write((i*i*i) + ", ");
    Console.WriteLine(); 
}


Table(InputNumber());