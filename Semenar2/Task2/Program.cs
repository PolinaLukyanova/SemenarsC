﻿// Напишите программу, которая вывоит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int n = new Random().Next(100, 1000); 
Console.WriteLine($"Случайное число {n}");

int n1 = n / 100; // кол-во сотен
int n3 = n % 10; // кол-во едениц

Console.WriteLine(n1 * 10 + n3);
    