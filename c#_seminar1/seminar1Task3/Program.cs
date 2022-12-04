//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру

//Считываем число с консоли
Console.Write ("Введите число от 1 до 7: ");
string? num1Line = Console.ReadLine();

//Проверяем данные на пустую строку
if (num1Line != null)
{
    //Наполняем массив
    string[] dayWeek = new string[7];
    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";

    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    //Находим день недели по номеру
    string outDayOfWeek = dayWeek[num1 - 1];
    //Выводим ответ
    Console.WriteLine(outDayOfWeek);
}

//Варианты

//Считываем данные с консоли
//string? inputLine = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
//if (inputLine != null)
//{

//ВАРИАНТ С МАССИВОМ

    //Создаем массив с днями недели
    //    string[] dayOfWeek = new string[7];
    //    dayOfWeek[0] = "понедельник";
    //    dayOfWeek[1] = "вторник";
    //    dayOfWeek[2] = "среда";
    //    dayOfWeek[3] = "четверг";
    //    dayOfWeek[4] = "пятница";
    //    dayOfWeek[5] = "суббота";
    //    dayOfWeek[6] = 
    //Находим название дня недели по введенному номеру
    //    string outDayOfWeek = dayOfWeek[inputNumber-1];
    //string outDayOfWeek = string.Empty;

//ВАРИАНТ С МЕТОДОМ

    // switch (inputNumber)
    // {
    //     case 1: outDayOfWeek = "понедельник"; break;
    //     case 2: outDayOfWeek = "вторник"; break;
    //     case 3: outDayOfWeek = "среда"; break;
    //     case 4: outDayOfWeek = "четверг"; break;
    //     case 5: outDayOfWeek = "пятница"; break;
    //     case 6: outDayOfWeek = "суббота"; break;
    //     case 7: outDayOfWeek = "воскресенье"; break;
    //     default: outDayOfWeek = "это не день недели!"; break;
    // }

// ВАРИАНТ С ФУНКЦИЕЙ ОС

//    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));


    // Выводим данные в консоль 
//    Console.WriteLine(outDayOfWeek);
//}
