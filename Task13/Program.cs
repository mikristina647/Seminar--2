﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного c клавиатуры числа или сообщает, что третьей цифры нет. Обращаться к числу как к строке нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int n = N;
if (N <= 99)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (N > 999)
       {
         N = N / 10;
       }
    int result = N % 10;
    Console.Write($"{result} является третьей цифрой от числа {n}");
}    
