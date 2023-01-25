﻿//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int GetQuantityOfNumbers(string message)
{
    Console.WriteLine(message);
    int NumberM = int.Parse(Console.ReadLine()!); 
    return NumberM;
}
int Length= GetQuantityOfNumbers("Input the quantity of numbers you want to enter");


int [] GetUserArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         Console.WriteLine($"Input element with index {i}  ");
         array [i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
int [] Array = GetUserArray (5); 

void ArrayOutput (int [] Array)
{
    Console.Write ($"[");
    for(int i = 0; i <Array.Length; i ++)
    {
        if (i != Array.Length-1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}]");
        }
    }
}
ArrayOutput (Array);

