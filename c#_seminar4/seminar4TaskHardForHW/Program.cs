// Написать программу, которая запрашивает ввод имен одной строкой и выводит случайный выбор одного из них

string ReadFromConsole(string msg)    // input data method
{
    Console.Write(msg);
    string inputString = Console.ReadLine() ?? "";
    return inputString;
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

string RandomSelectOneFromAll (string line) // random selection one element from input string
{
    string[] names = line.Split(",");
    return names[new Random().Next(1, names.Length+1)];
}

string nameLine = ReadFromConsole("Введите имена через запятую: "); // data entry prompt
PrintData ("В этот раз за пивом идет... "+RandomSelectOneFromAll(nameLine)+"!");    //output result