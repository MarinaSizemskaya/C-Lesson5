// Задача 3: Задайте массив из 8 случайных чисел. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

using System;
using static System.Console;
Clear();

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i]=new Random().Next(0, 100);
    Write(array[i] + " ");
}
WriteLine();
Write("Введите число: ");
int A = int.Parse(ReadLine());
int count = 0;
for (int i = 0; i < 8; i++)
{
    if (array[i]==A) 
    {
        count++;
    }
}
if (count > 0) WriteLine("Такое число присутствует в массиве");
else WriteLine("Такого числа нет в массиве");