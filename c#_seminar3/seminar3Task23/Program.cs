// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int inputNum = ReadData("Введите число: ");         // input number
int numSt = ReadData("Введите степень числа: ");    // input degree of number 

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

string LineBuilder(int arg, int pow)    // line constructor method
{
    string line = String.Empty;

    for (int i = 1; i < arg; i++)
    {
        line = line + Math.Pow(i, pow) + " ";
    }
        line = line + Math.Pow(arg, pow);
    
    return line;
}

PrintData(LineBuilder(inputNum, 1));        // output line of numbers from 1 to inputNum
PrintData(LineBuilder(inputNum, numSt));    // output line degree of numbers from 1 to inputNum









// * Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * 3 -> 1, 8, 27
// * 5 -> 1, 8, 27, 64, 125
// */ 

// Console.Write("Введите число: ");
// int rows = 6; // является показателем степени и одновременно количеством строк в таблице
// int n;
// bool isNumber = int.TryParse(Console.ReadLine(), out n);
// validate(isNumber);

// int[,] table = new int[rows,n];

// //заполняем таблицу
// fillTable(table,n,rows);
// Console.WriteLine("*** Таблица степеней чисел от 1 до "+n+" и степеней от 1 до "+rows);
// printTable(table,n,rows);


// //================методы============================//

// void printTable(int[,] table,int n, int rows){
// //декорируем значения таблицы
//     string[,] decoratedTable = GetDecoratedTable(table,rows,n);

//     int tableWidth =  GetMaxTableWidth(n,GetMaxWidth(table,rows,n));
//     string line = GetLine(tableWidth);
//     string lineWithBorders = GetLineWithBorders(tableWidth,GetMaxWidth(table,rows,n));
//     Console.WriteLine(line);
//     for (int i = 0; i<rows; i++){
//         for (int j = 0; j<n ; j++){
//             Console.Write(decoratedTable[i,j]);
//         }
//         Console.WriteLine("|\n"+lineWithBorders);
//     }
// }

// void fillTable(int[,] table, int n, int rows){
//     //заполняем первую строку таблицы
//     for (int i = 0; i < n ; i++) {
//        table[0,i] = i+1;
//     }
//     for (int i = 1; i< rows ; i++){
//         for (int j = 0; j < n ; j++){
//             table[i,j] = (int)Math.Pow(table[0,j],(i+1));
//         }
//     }
// }

// string[,] GetDecoratedTable(int[,] table, int rows, int n){
//     string[,] decoratedTable = new string[rows,n];

    
//     int columnWidth = GetMaxWidth(table,rows,n);

//      for (int i = 0; i<rows; i++){
//         for (int j = 0; j<n ; j++){
//            decoratedTable[i,j] = getStringWithSpaces(columnWidth,table[i,j]);
//         }
//     }
//     return decoratedTable;
// }

// string getStringWithSpaces(int requiredWidth, int value) {
//     string valueStr = value + "";
//     int valueLength = valueStr.Length;
//     int spaces = requiredWidth-valueLength;
//     for (int i = 0 ; i < spaces ; i ++) {
//         valueStr = " " + valueStr;
//     }
//     return "|"+valueStr;
// }

// //максимальная ширина колонки, +1 чтобы числа не прилипали
// int GetMaxWidth(int[,] table, int row, int n){
//     return (table[rows-1,n-1]+"").Length + 1;
// }

// int GetMaxTableWidth(int n, int columnWidth){
//     //количество знаков '|'
//     int tableWidth = n+1;
//     //длинна всех чисел
//     tableWidth+= n*columnWidth;
//     return tableWidth;
// }

// string GetLine(int tableWidth){
//     string line ="";
//     for (int i = 0; i < tableWidth ; i ++){
//         line+="_";
//     }
//     return line;
// }

// string GetLineWithBorders(int tableWidth, int columnWidth){
//     string line = "|" + GetLine(columnWidth);
//     string lineWithBorders = "";
//     for (int i = 0 ; i < tableWidth-1 ;i+=columnWidth+1){
//         lineWithBorders+=line;
//     }
//     return lineWithBorders+ "|";
// }

// void validate(bool isNumber){
//     if (!isNumber){
//         Console.WriteLine("Вы ввели не число, выход");
//         Environment.Exit(0);
//     }
// }
