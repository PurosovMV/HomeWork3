/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введи пятизначное число: ");
int input = int.Parse(Console.ReadLine());
if (input > 99999 || input < 10000)
{
    Console.WriteLine("Введённое число не пятизначное!");
}
else if (input / 10000 == input % 10 && (input % 10000 - input % 1000) / 1000 == (input % 100 - input % 10) / 10)
{
    Console.WriteLine($"{input} -> Да");
}
else
{
    Console.WriteLine($"{input} -> Нет");
}
