/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Polidrom(int num)
{
    int b = num;
    int c = 0;
    while (b != 0)
    {
        c = c * 10 + (b % 10);
        b = b / 10;
    }
    if (num == c)
    {
        Console.WriteLine("Введённое число палиндром");
    }
    else
    {
        Console.WriteLine("Введённое число не палиндром");
    }
}
Console.Write("Введите  пятизначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
Polidrom(num);
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cub(int a)
{
    int c = 1;
    int i = 1;
    while (i <= a)
    {
        c = i * i * i;
        Console.WriteLine(i + " в кубе = " + c);
        i++;
    }
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Cub(num);
*/

/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(double x1,double y1,double z1, double x2, double y2, double z2)
{
    double S=(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1);
    S= Math.Sqrt(S);
    return S;
}

Console.Write("Введите координату х первой точки=");
double x1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки=");
double y1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки=");
double z1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки=");
double x2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки=");
double y2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки=");
double z2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Distance (x1,y1,z1,x2,y2,z2));
*/