/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int numA = EnterInt("Введите неотрицательное целое число A: ");
int numB = EnterInt("Введите неотрицательное целое число B: ");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

int AckermanFunction (int numA, int numB)
{
    if (numA == 0) 
        return numB + 1;
    if (numA > 0 && numB == 0) 
        return AckermanFunction (numA - 1, 1);
    return AckermanFunction (numA - 1, AckermanFunction (numA, numB - 1));
}

Console.WriteLine($"Функция Аккермана для {numA} и {numB} составляет {AckermanFunction (numA, numB)}");

/* Кстати, число ГУГОЛ (10 в сотой степени) тоже настолько велико, что количество цифр 
в порядке этого числа многократно превосходит количество атомов в наблюдаемой части Вселенной. */
