//Считываем число с консоли
string? Num1Line = Console.ReadLine ();

//Проверяем данные на пустую строку
if(Num1Line!=null);
{
    //Парсим введенное число
    int num1 = int.Parse(Num1Line);
    
    //Находим квадрат числа
    int outResult = num1*num1;
    
    //Вариант 2 int outResult = (int)Math.Pow(num1,2);
    
    //Выводим результат
    Console.WriteLine(outResult);
}