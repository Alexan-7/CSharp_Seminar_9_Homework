/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. */

Console.WriteLine("Задайте целое значение N и мы выведем все натуральные числа в промежутке от N до 1.");
int numb = int.Parse(Console.ReadLine()!);

void PrintRangeNumbers(int number)
{
    if (number < 1)
    {
        Console.WriteLine("| натуральные числа - это положительные целые числа от 1 до бесконечности");
        return;  // не комментить! Сигнал для прерывания
    }
    Console.Write($"{number} ");
    PrintRangeNumbers(number - 1);
}

PrintRangeNumbers(numb);