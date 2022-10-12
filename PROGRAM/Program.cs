﻿/*Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */
void PrintArray(string[] arr)
{
    if (arr.Length == 0)
    {
        System.Console.WriteLine("Массив пустой");
        return;
    }
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        {
            System.Console.Write(", ");
        }
        else System.Console.WriteLine("]");
    }
}
string[] NewArray(string[] array)
{
    int lenarray2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            lenarray2++;
        }
    }
    string[] array2 = new string[lenarray2];
    for (int i = 0, j = 0; i < array.Length && j < lenarray2; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j++] = array[i];
        }
    }
    return array2;
}
string[] array = { "123", "157", "-2111 12", "+15111", "computer science" };
System.Console.WriteLine("Исходный массив:");
PrintArray(array);
string[] myarray = NewArray(array);
System.Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArray(myarray);