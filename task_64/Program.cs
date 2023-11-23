// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readInput = Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

void PrintNumberNFrom1 (int number)
{
    if (number > 1)
    {
        System.Console.Write($"{number}, ");
        PrintNumberNFrom1(number - 1);
    }
    else if (number ==  1) 
    {
        System.Console.WriteLine("1");
    }
}

int N = Prompt("Enter a number N: ");

PrintNumberNFrom1(N);