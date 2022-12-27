// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.

// check possible values of arguments before stack overflow
for (int n = 0; n <= 12; n++)
{
    for (int m = 0; m <= 4; m++)
    {
        Console.WriteLine($" A ({n}, {m}) = {AckermannFunc(m, n)}");
    }
}

//METHOD
int AckermannFunc(int n, int m) // calc the Ackermann function via recursion
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AckermannFunc(n - 1, 1);
    else
        return AckermannFunc(n - 1, AckermannFunc(n, m - 1));
}