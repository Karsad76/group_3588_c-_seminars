// Задача №9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Random numberSintezator = new System.Random();   // создаем экземпляр класса рандомайзер

// ВАРИАНТ 1
int number = numberSintezator.Next(10,100);             // получаем случайное число
Console.WriteLine (number);

int firstNumber = number/10;                            // получаем старший разряд числа
int secondNumber = number%10;                           // получаем младший разряд числа

if (firstNumber>secondNumber)                           // сравниваем
{
    Console.WriteLine (firstNumber);                    // вывод TRUE
}
else
{
    Console.WriteLine(secondNumber);                    // вывод FALSE
}

// ВАРИАНТ 2
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray(); // получаем число из рандомайзера, переводим в строку 
                                                                        // и кладем в символьный массив

Console.WriteLine (digits);

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine (resultNumber);
