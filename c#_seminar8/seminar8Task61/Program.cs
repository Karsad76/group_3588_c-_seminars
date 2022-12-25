// Задача №61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int qtyOfRows = ReadData("Введите кол-во строк треугольника Паскаля: ");
PrintTriangle(qtyOfRows);

float Factorial(int n) // Pascal's triangle element calculation method
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintTriangle(int rows)    // method for calculate and print Pascal's triangle
{
    for (int i = 0; i < rows; i++)
    {
        // print spaces for center alignment 
        for (int j = 0; j <= (rows - i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            // print triangle elements
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
        }
        Console.WriteLine();
    }
}