/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Например:
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Да, {number} - палиндром");
    }
    else
    {
        Console.WriteLine($"Нет, {number} - не палиндром");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число");
}