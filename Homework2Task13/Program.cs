// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

//Считываем данные с консоли
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");
 //создаем цикл, при наличии 3 цифр
 if (number>99)
{
    //подсчет количества цифр в числе, с помощью логарифма
    int length = (int)Math.Log10(number)+1;

    int index = 0;
    int thirdDigit = number;
    //деление числа на 10 раз
    while (index < length-3)
    {
        thirdDigit = thirdDigit/10;
        index++;
    }
    thirdDigit = thirdDigit%10; //находим 3 цифру остатком от деления на 10
    Console.WriteLine(thirdDigit + " третья цифра числа " + number);
}
else //если в числе меньше 3 цифр
{
    Console.WriteLine("-> третьей цифры нет");   
}
