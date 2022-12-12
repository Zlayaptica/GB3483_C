// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите число: "); //ввод данных
// string number = Console.ReadLine();
// int lenNumber = number.Length;

// if (lenNumber == 5)
// {
//     if (number[0] == number[4]||number[1] == number[3]) //проверка равенства значений
//     {
//         Console.WriteLine($"{number} - Палиндром"); //вывод данных
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }


//ввод данных
int outputNumber = ReadData("Введите пятизначное число ");
//проверка корректности введенных данных
if (outputNumber>=10000&&outputNumber<=99999)
{
    //создаем словарь
    var palindrome = new Dictionary<int, int>();
    palindrome = DictionaryFill();
    //проверка наличия данных в словаре
    bool chek = PalinTest(outputNumber, palindrome);
    if (chek)
    {
        PrintData(outputNumber, " palindrome");
    }
    else
    {
        PrintData(outputNumber, " not palindrome");
    }
}
else
{
    Console.WriteLine("Введенные данные не корректны");
}
//метод считывания данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}
//метод вывода результата
void PrintData(int num, string msg)
{
    Console.WriteLine(num+msg);
}
//метод fill извлекает из словаря данные
Dictionary<int, int> DictionaryFill()
{
    var dictionary = new Dictionary<int, int>();
    int keyNumber = 1;
        for(int secondNumber = 0; secondNumber<=9; secondNumber++)
        {
            for (int firstNumber = 1; firstNumber<=9; firstNumber++)
            {
                dictionary[keyNumber] = firstNumber*1000+secondNumber*100+secondNumber*10+firstNumber;
                keyNumber++;
            }
        }
    return dictionary;
}
//метод проверяет, если 5 чисел палиндром
bool PalinTest(int number,Dictionary<int, int> palindrome)
{
    bool result = false;
    if (palindrome.ContainsValue((number/1000)*100+(number%100)))
    {
        result = true;
    }
    return result;
}