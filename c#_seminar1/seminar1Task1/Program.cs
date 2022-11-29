//Считываем число с консоли
string? num1Line = Console.ReadLine ();
string? num2Line = Console.ReadLine ();

//Проверяем данные на пустую строку
if(num1Line!=null&&num2Line!=null);
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    
    if (num1 == num2*num2)
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    else
    {
        Console.WriteLine("Первое число НЕ квадрат второго");
    }
}
