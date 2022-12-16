// Задача №40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int a = ReadData ("Введите первое число: ");
int b = ReadData ("Введите второе число: ");
int c = ReadData ("Введите третье число: ");

if (TriangleTest(a,b,c)) {PrintData ("Треугольник");}
else{PrintData ("Не треугольник");}
// PrintData ("Треугольнику быть? "+TriangleTest(a,b,c));

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

bool TriangleTest (int a1, int b1, int c1)      // check triangle method
{
    return ((a1+b1>c1)&&(a1+c1>b1)&&(b1+c1>a1));
}