//================== Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Через строку решать нельзя.
//
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputFiveDigitNumber()
{
    int inputNumber = -1;
    bool crash = true;
    while (crash == true)
    {
        Console.Write("Введите пятизначное число > ");
        inputNumber = Convert.ToInt32(Console.ReadLine());
        if ((inputNumber > 9999) && (inputNumber < 100000))
            crash = false;
        else
            Console.WriteLine("Неправильное число !");
    }
    return inputNumber;
}    

void VerificateNumber(int palindrom)
{
    if ((palindrom / 10000 == palindrom % 10) && (palindrom / 1000 % 10 == palindrom % 100 / 10))
        Console.WriteLine($"{palindrom} -> да");
    else
        Console.WriteLine($"{palindrom} -> нет");
}


VerificateNumber(InputFiveDigitNumber());