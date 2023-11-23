using System;
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string massage)
{
    System.Console.Write(massage);
    string readInput = Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int PrintSum(int numberOne, int numberTwo)
{
    if (numberOne != numberTwo)
    {
        if (numberOne > numberTwo)
        {
            return PrintSum(numberOne, numberTwo + 1) + numberTwo;
        }
        if (numberOne < numberTwo)
        {
            return PrintSum(numberOne + 1, numberTwo) + numberOne;
        }
    }
    return numberOne;
}

int M = Prompt("Input M -> ");
int N = Prompt("Input N -> ");

System.Console.WriteLine($"Sum = {PrintSum(M, N)}");