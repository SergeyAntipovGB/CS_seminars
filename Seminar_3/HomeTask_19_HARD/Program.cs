//================== Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число
// любой разрядности и проверяет, является ли оно палиндромом.
// Через строку нельзя решать само собой. 

int whouManyDigit = InputDigitNumber();
int number = GenerateNumber(whouManyDigit);
int[] matrixN = new int[whouManyDigit];
NumToMatrix(whouManyDigit, number);
VerificateNumber(matrixN, whouManyDigit, number);


int InputDigitNumber()
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

int GenerateNumber(int n)
{
    int num = new Random().Next(2, n);
    return num;
}

void NumToMatrix(int digit, int length)
{
    for (int i = length - 1; i > 0; i--)
    {
        matrixN[i] = digit % 10;
        digit = digit / 10;
    }
    matrixN[0] = digit;
}

void VerificateNumber(int[] palindrom, int length, int number)
{
    bool question = true;
    for (int i = 0; i < ((length - 1) / 2); i++)
    {
        for (int j = (length - 1); j > ((length - 1) / 2); j--)
        {
            if ((palindrom[i] != palindrom[j]))
            {
                Console.WriteLine($"Число {number} не является палиндромом");
                break;
            }
        }
    }
    Console.WriteLine($"Число {number} является палиндромом");
    // if ((palindrom / 10000 == palindrom % 10) && (palindrom / 1000 % 10 == palindrom % 100 / 10))
    //     Console.WriteLine($"{palindrom} -> да");
    // else
    //     Console.WriteLine($"{palindrom} -> нет");
}


