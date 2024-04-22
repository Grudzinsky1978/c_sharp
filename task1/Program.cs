// Задача 1.
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// M = 8; N = 4 -> "8, 7, 6, 5, 4"

void PrintNaturalNumbersLH(int numstart, int numend)
{
    int num = numend;
    if (num < numstart)
    {
        return;
    }
    PrintNaturalNumbersLH(numstart, numend - 1);
    Console.Write($"{num}, ");
}

void PrintNaturalNumbersHL(int numstart, int numend)
{
    int num = numstart;
    if (num > numend)
    {
        return;
    }
    PrintNaturalNumbersHL(numstart + 1, numend);
    Console.Write($"{num}, ");
}

Console.WriteLine("Введите натуральное число — начало желаемого диапазона всех натуральных чисел: ");
int naturalnumberstart = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число — конец желаемого диапазона всех натуральных чисел: ");
int naturalnumberend = Convert.ToInt32(Console.ReadLine());

if (naturalnumberstart > 0 && naturalnumberend > 0)
{

    if (naturalnumberstart < naturalnumberend)
    {
        PrintNaturalNumbersLH(naturalnumberstart, naturalnumberend);
    }
    else
    {
        PrintNaturalNumbersHL(naturalnumberend, naturalnumberstart);
    }
}
else
{
    Console.WriteLine("Число должно быть больше нуля!");
}