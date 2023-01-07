/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

//функция получения числа с консоли
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }

    return result;
}

//Нахождение N чисел рекурсией
void findN(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} ");
        n -= 1;
        findN(n);
    }
    else;
}

int n = GetNumber("Введите число N");

Console.WriteLine($"Это все натуральные числа от {n} до 1");

findN(n);