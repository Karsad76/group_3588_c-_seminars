// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
System.Random numberSintezator = new System.Random();   // создаем экземпляр класса рандомайзер

int num = numberSintezator.Next(100,1000);              // получаем случайное число
Console.WriteLine (num);

// ВАРИАНТ 1
int firstNum = num/100;                             // получаем старший разряд числа
int secondNum = num%10;                             // получаем младший разряд числа

int result = firstNum*10 + secondNum;               // собираем новое число
Console.WriteLine (result);

// ВАРИАНТ 2
Console.WriteLine ((num/100)*10 + num%10);