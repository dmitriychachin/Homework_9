/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

//Функция Аккармена
int Akker(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akker(n - 1, 1);
    else
      return Akker(n - 1, Akker(n, m - 1));
}

int n = GetNumber("Введите число N");
int m = GetNumber("Введите число M");

Console.WriteLine();

Console.WriteLine($"Число функции Аккармена при значении N = {n} и M = {m}, равно {Akker(n, m)}");