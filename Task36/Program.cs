// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

using System;
using static System.Console;

Clear();
int size = new Random().Next(4, 10);
int[] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i]=new Random().Next(-50, 51);
    Write(array[i] + " ");
}
int sum = 0;
for (int i = 0; i < size; i++)
{
    if (i%2!=0)
    {
        sum = sum+array[i];
    }
}
WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum}");