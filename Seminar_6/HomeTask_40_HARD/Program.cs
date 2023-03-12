// ============================  задача 40 - HARD необязательная.
// На вход программы подаются три целых положительных числа. Определить ,
// является ли это сторонами треугольника. Если да, то вывести всю
// информацию по нему - площадь, периметр, значения углов треугольника в градусах,
// является ли он прямоугольным, равнобедренным, равносторонним.

int InputLines()
{
    bool sequre = false;
    int num = -1;
    do
    {
        Console.Write("Введите длину стороны треугольника > ");
        num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("Введено отрицательное число");
            sequre = false;
        }
        else sequre = true;
    } while (sequre == false);
    return num;
}

bool SequreTriangle(int a, int b, int c)
{
    if ((a > b + c) || (b > a + c) || (c > a + b))
        return false;
    return true;
}

int Angle(int sideLeft, int sideRihgt, int sideOpposite)
{
    int angle = Convert.ToInt32(Math.Acos((Math.Pow(sideLeft, 2) + Math.Pow(sideRihgt, 2)
        - Math.Pow(sideOpposite, 2)) / (2 * Convert.ToDouble(sideLeft)
        * Convert.ToDouble(sideRihgt))) * 180 / Math.PI);
    return angle;
}

string WhichT(int angleAB, int angleBC, int angleAC)
{
    if ((angleAB == angleBC) && (angleAB == angleAC)) return "равносторонний";
    else if ((angleAB == 90) || (angleBC == 90) || (angleAC == 90)) return "прямоугольный";
    else if ((angleAB == angleBC) || (angleBC == angleAC) || (angleAB == angleAC)) return "равнобедренный";
    else return "простой";
}

// int SquareSY(int a)
// {
//     return Convert.ToInt32(Math.Sqrt(a * a - Math.Pow(a / 2)) * a / 2);
// }

// int SquareSA(int a, int b, int c)
// {
//     int cont = 0;
//     if (a == b) cont = Convert.ToInt32(Math.Sqrt(a * a - Math.Pow(c / 2)) * c / 2);
//     else if (a == c) cont = Convert.ToInt32(Math.Sqrt(a * a - Math.Pow(b / 2)) * b / 2);
//     else cont = Convert.ToInt32(Math.Sqrt(b * b - Math.Pow(a / 2)) * a / 2);
//     return cont;
// }

// int SquareSL(int a, int b, int c)
// {
//     int cont = 0;
//     if ((c > a) && (c > b)) cont = a * b;
//     else if ((a > b) && (a > c)) cont = b * c;
//     else cont = a * c;
//     return cont;
// }


int a = InputLines();
int b = InputLines();
int c = InputLines();

bool triangle = SequreTriangle(a, b, c);
if (triangle == false) Console.WriteLine("Этот треугольник вырожденный !");
else
{
    int perimeter = a + b + c;
    int pp = perimeter / 2;
    int angleAB = Angle(a, b, c);
    int angleBC = Angle(b, c, a);
    int angleAC = Angle(a, c, b);

    string whichTriangle = WhichT(angleAB, angleBC, angleAC);

    double s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
    // if (whichTriangle == "равносторонний") s = SquareSY(a);
    // else if (whichTriangle == "равнобедренный") s = SquareSA(a, b, c);
    // else if (whichTriangle == "прямоугольный") s = SquareSL(a, b, c);
    // else 

    Console.WriteLine($"Стороны треугольника равны {a}, {b}, {c}");
    Console.WriteLine($"Этот треугольник {whichTriangle}");
    Console.WriteLine($"Площадь S = {s}");
    Console.WriteLine($"Периметр Р = {perimeter}");
    Console.WriteLine($"Углы <АВ, <ВС, <АС соответственно равны {angleAB}"
        + $", {angleBC}, и {angleAC} градусов соответственно");

}

