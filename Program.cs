﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
String[] array = new string[3] {"soul", "war", "it"};
String[] result = new string[array.Length];

for(int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[i] = array[i];
        Console.WriteLine(result[i]);
    }
}
