﻿// Напишите программу, которая на вход принимает два целых числа и проверяет ,
// является ли первое число квадратом второго

// int first = 25;
// int second = 5;

// if (second * second == first)
// {
//     Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все 
// целые числа в промежутке от -N до N

// int n = 8;
// int i = -n;
// while (i <= n)
// {
//    Console.Write(i + " ");
//    i++;
// }

// второй варинат этой программы (используя цикл)
//int n = 8;
//for (int i = -n; i <= n; i++)
//{
//    Console.Write(i + " ");
//}

// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает 
// сумму первой и последней цифры этого числа
int num = 326;
int first = num /100;
int last = num % 10;
{
    Console.Write("Sum first and last digit is " + (first + last));
}