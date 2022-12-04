// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//Считываем данные с консоли
string? inputNumber = Console.ReadLine();

if (inputNumber != null) //проверяем, не нулевые ли данные
{
    int inputLine = int.Parse(inputNumber); //конвертация в целое число
    int index = 2; //начало со 2 числа, т.к. нужны только четные чилс

    string outLine = string.Empty; // создаем пустую строку

    while (index<=inputLine-2) //цикл сбора четных чисел в строку
    {
        outLine = outLine + index + ","; //собираем все числа в строке
        index = index + 2;  
    }
    outLine=outLine+index;
    
    Console.WriteLine(outLine);
}
