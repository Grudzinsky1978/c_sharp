// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
//Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int[] CreateArrayRndInt(int count, int min, int max)
{
    int[] array = new int[count];
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}


void PrintFlipArray(int[] array, int first = 0)
{
    if (first != array.Length)
    {
        PrintFlipArray(array, first + 1);
        Console.Write($"{array[first]}, ");
    }
}


Console.WriteLine("Введите количество элементов будущего массива из чисел: ");
int countelem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите наименьшее число в будущем произвольном массиве: ");
int minnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите наибольшее число в будущем произвольном массиве: ");
int maxnum = Convert.ToInt32(Console.ReadLine());

int[] arrayrnd = CreateArrayRndInt(countelem, minnum, maxnum);
PrintArray(arrayrnd);
Console.WriteLine("\n Развёрнутый массив: ");
PrintFlipArray(arrayrnd);