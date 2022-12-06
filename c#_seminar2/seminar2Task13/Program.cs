// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите трех- или более разрядное число: ");     // data entry prompt
int numA = int.Parse(Console.ReadLine() ?? "0");                // console input parsing to int
int countNumOfDigits = 10;                                      // counter number of digits init

if (Math.Abs(numA) > 99)                                        // input range validation
{
    while (Math.Abs(numA) / countNumOfDigits >= 1)              // cycle to count the number of digits 
    {
        countNumOfDigits = countNumOfDigits * 10;               // counter+
    }
    // output the third digit of input number if input range correct
    Console.WriteLine("Третья цифра введенного числа: " + (Math.Abs(numA) / (countNumOfDigits / 1000)) % 10); 
}
else
{
    // output message if input range incorrect
    Console.WriteLine("Вы ввели число с меньшим кол-вом разрядов. Третьей цифры в нем нет. Попробуйте снова");
}