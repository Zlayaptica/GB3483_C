// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


//ввод данных
int inputNum = ReadData("Введите число ");
string[] firstRow = LineBuild(inputNum,1).Split(" ");
string[] secondRow = LineBuild(inputNum,3).Split(" ");
Console.Write(" ");
for (int i=1; i<=LineBuild(inputNum,3).Length;i++) {Console.Write("_");}
Console.Write("\n");
string[] space = new string[inputNum];
for(int num=0; num<inputNum;num++)
{
    for (int i=1; i<=(secondRow[num].Length-firstRow[num].Length);i++)
    {
        space[num] = space[num] + " ";
    }
    firstRow[num] = space[num]+firstRow[num];
}
string[] line = new string[inputNum];
for(int num=0; num<inputNum; num++)
{
   line[num]=String.Concat(Enumerable.Repeat("_",secondRow[num].Length)); 
}
PrintData(firstRow);
PrintData(line);
PrintData(secondRow);
PrintData(line);

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}
string LineBuild(int num, int pow)
{
    string line = string.Empty;
    for (int i=1; i<num; i++)
    {
        line = line+Math.Pow(i,pow)+ " ";
    }
    line = line + Math.Pow(num,pow);
    return line;
}
void PrintData(string[] line)
{
    foreach (var num in line)
    {
        Console.Write($"|{num}");
    }
    Console.WriteLine("|");
}



// //ввод данных
// Console.WriteLine(line);
// //считываем данные
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }
// string lineBuilder(int n)
// {
//     string line = "";
//     string line2 = "";
//     for (int i = 1; i<n; i++){

//     }
// }