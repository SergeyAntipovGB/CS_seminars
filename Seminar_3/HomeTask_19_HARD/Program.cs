//================== Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число
// любой разрядности и проверяет, является ли оно палиндромом.
// Через строку нельзя решать само собой. 

int InputDigitNumber()  // запрашивает разрядность числа
{
    int inputNumber = -1;
    bool crash = true;
    while (crash == true)
    {
        Console.Write("Введите количество разрядов от 2 до 9 > ");
        inputNumber = Convert.ToInt32(Console.ReadLine());
        if ((inputNumber > 1) && (inputNumber < 10))
            crash = false;
        else
            Console.WriteLine("Неправильное число !");
    }
    return inputNumber;
}

int GenerateNumber(int n)  // генерирует случайное число указанной с клавиатуры разрядности
{
    int num = new Random().Next(Convert.ToInt32(Math.Pow(10, n-1)),
        Convert.ToInt32(Math.Pow(10, n)));
    return num;
}

void VerificateNumber(int[] palindrom, int length, int number)  // Проверяет признаки палиндрома
{
    string question = "является";
    for (int i = 0; i < (length / 2); i++)
        if ((palindrom[i] != palindrom[length - 1 - i]))
            question = "не является";
    Console.WriteLine($"Число {number} {question} палиндромом");
}


int howManyDigit = InputDigitNumber();
int number = GenerateNumber(howManyDigit);
int[] matrixN = new int[howManyDigit];
NumToMatrix(howManyDigit, number);
VerificateNumber(matrixN, howManyDigit, number);


void NumToMatrix(int length, int digit)  // разбирает анализируемое число на разряды
{
    for (int i = length - 1; i >= 0; i--)
    {
        matrixN[i] = digit % 10;
        digit /= 10;
    }
}