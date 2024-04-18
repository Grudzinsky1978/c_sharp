// Задача 2.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// Пример:
// m = 2, n = 3 => A(m,n) = 29 (Согласно таблице в Википедии, здесь ошибка, результат должен быть 9)
// m = 11, n = 3 => A(m,n) = 16381 (При данных значениях произошло переполнение стека, тестировал при меньших значениях)

// https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
// Функция Аккермана. Псевдокод из Википедии
// функция ack(n, m)
//     если n = 0
//         вернуть m + 1
//     иначе, если m = 0
//         вернуть ack(n - 1, 1)
//     ещё
//         вернуть ack(n - 1, ack(n, m - 1))

int funcAckermann(int numf, int nums)
{
    if (numf == 0)
    {
        return nums + 1;
    }
    if (nums == 0)
    {
        return funcAckermann(numf - 1, 1);
    }
    return funcAckermann(numf - 1, funcAckermann(numf, nums - 1));
}

Console.WriteLine("Введите 1-е натуральное число для вычисления функции Аккермана: ");
int naturalnumberfirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е натуральное число для вычисления функции Аккермана: ");
int naturalnumbersecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(funcAckermann(naturalnumberfirst, naturalnumbersecond));

// Тестовые значения
// 0, 0 => 1
// 0, 1 => 2
// 1, 1 => 3
// 1, 2 => 4
// 2, 2 => 7
// 2, 3 => 9
// 3, 3 => 61
// 3, 4 => 125
// 3, 5 => 253