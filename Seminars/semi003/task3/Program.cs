﻿// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

void Destroid(int[] array, int number)
{
    bool temp = false;

    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
        {
            temp = true;
            break;
        }
        
    }
    if (temp)
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("ноооуу");
    }
    return temp;
    
}

int length = ReadNumber("Введите длину массива");
int leftRange = ReadNumber("Введите левую границу массива");
int rightRange = ReadNumber("Введите правую границу массива");
int[] array = GetRandomArray(length, leftRange, rightRange); 

int find = ReadNumber("Введие число а я скажу есть ли оно или нет");
Console.WriteLine(Destroid);