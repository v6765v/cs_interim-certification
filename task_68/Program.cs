using System;
﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string massage)
{
    System.Console.Write(massage);
    string readInput = Console.ReadLine();
    return Convert.ToInt32(readInput);
}

int functionsA(int numberOne, int numberTwo)
{
    if (numberOne == 0)   
    {
        return numberTwo + 1;
    }
        
    else if (numberOne > 0 && numberTwo == 0)  
    {
        return functionsA(numberOne - 1, 1);
    }
    
    else if (numberOne > 0 && numberTwo > 0)
    {
        return functionsA(numberOne - 1, functionsA(numberOne, numberTwo - 1));
    }
    else return 0;
}

int M = Prompt("enter the M -> ");
int N = Prompt("enter the N -> ");

System.Console.WriteLine($"A({M},{N}) = {functionsA(M, N)}");