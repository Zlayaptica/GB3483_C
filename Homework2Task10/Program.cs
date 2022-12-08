// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


string? inputLine = Console.ReadLine(); //считывание данных
int inputNumber = Convert.ToInt32(inputLine); 
string stNumber = Convert.ToString(inputNumber);//конвертация в строку
Console.WriteLine("вторая цифра этого числа -> " + stNumber[1]); //вывод данных


