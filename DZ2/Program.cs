/*Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
void ReduceNumber()
{
    Console.Write("Введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num2;
    num2 = num / 10 % 10;
    Console.WriteLine("второе число в числе " + num + " -> " + num2);
}
ReduceNumber();
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
/*void FreeNumber()
{
    Console.Write("Введите  число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 100)
    {
        Console.WriteLine(num + " -> " + "третьго числa в этом числе нет ");
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }

        int num2;
        num2 = num / 1 % 10;
        Console.WriteLine("третий символ в этом числе " +  " -> " + num2);
    }
}
FreeNumber();
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*void FreeNumber()
{
    Console.Write("Введите  число от 1 до 7: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num <6)
    {
        Console.WriteLine(num + " -> " + "Сегодня рабочий день ");
    }
    if (num>5 && num<8)
    {
        Console.WriteLine(num + " Ура!!! Сегодня выходной ");
    }
    if (num>7)
    {
        Console.WriteLine(num + " number incorrect, input correct number");
    }
}
FreeNumber();
*/