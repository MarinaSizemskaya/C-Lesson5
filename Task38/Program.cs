// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;
using static System.Console;
Clear();

int size = new Random().Next(4, 10);
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i]=new Random().Next(-50, 51);
    Write(array[i] + " ");
}
double max = 0;
double min = 0;
for (int i = 0; i < size; i++)
{
    if (array[i]>max)
    {
        max = array[i];
    }
}
for (int i = 0; i < size; i++)
{
    if (array[i]<min)
    {
        min = array[i];
    }
}
double result = max - min;
WriteLine();
WriteLine($"Разница между Наибольшим и наименьшим элементами массива равна {result}");