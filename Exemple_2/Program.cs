/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

//Нахождение суммы от M до N
int sumNM(int m, int n)
{
    int sum = 0;

    if (m <= n)
    {
        sum += m;
        m++;
        sum = sum + sumNM(m, n);
    }
    else;

    return sum;
}

int m = GetNumber("Введите число M");
int n = GetNumber("Введите число N");

int sum = sumNM(m, n);

Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} равна {sum}");
