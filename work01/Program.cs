﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int numberMax = number1;
int numberMin = number1;

if (number2 > numberMax) numberMax =  number2;
    
System.Console.WriteLine("max = " + numberMax);

if (number2 < numberMin) numberMin =  number2;
    
System.Console.WriteLine("min = " + numberMin);

