﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int number = Convert.ToInt32(Console.ReadLine());

if (number%2==0)
{
    System.Console.WriteLine(number + " Yes");
}
else 
{
    System.Console.WriteLine(number + " No");
}

