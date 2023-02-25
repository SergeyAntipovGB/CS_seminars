// Принимает на вход целое число любой разрядности
// и выдает третью цифру слева этого числа или говорит, что такой цифры нет

Console.Write("введите целое многозначное число N = ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;

if (n > 99)
{
    while (n > 99)
    {
        res = n % 10;
        n = n / 10;
    }
    Console.WriteLine("третья цифра - " + res);
}
else
    Console.WriteLine("такой цифры нет");