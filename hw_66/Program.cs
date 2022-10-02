/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. */

Console.Clear();

int minM = EnterInt("Введите значение M: ");
int maxN = EnterInt("Введите значение N: ");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void SumInRange(int min, int max, int sum)
{
    if (min <= 0 || max <= 0)
    {
        Console.WriteLine("Натуральные числа - это положительные целые числа от 1 до бесконечности.");
        return;
    }

    else if (max < min)  // этот блок IF нужен, чтобы min++ не превысил max'а
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке этих чисел: {sum}");
        return;
    }

    sum += min++;
    SumInRange(min, max, sum);
}

SumInRange(minM, maxN, 0);