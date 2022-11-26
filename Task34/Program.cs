// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int count = 0;
for (int i = 0; i < size; i++)
{
    if(array[i]%2==0)
    {
        count++;
    }
}
WriteLine();
WriteLine($"В данном массиве {count} четных чисел");