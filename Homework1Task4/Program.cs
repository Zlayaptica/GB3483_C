// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//Считываем данные с консоли
int inputNum1 = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 -конвертирует данные в тип int
int inputNum2 = Convert.ToInt32(Console.ReadLine());
int inputNum3 = Convert.ToInt32(Console.ReadLine());

    int max = inputNum1; //принимаем за мах число 1

if (inputNum2 > max) //сравниваем число 2 с мах
{
     max = inputNum2; //принимаем за мах число 2
}
if (inputNum3 > max) //сравниваем число 3 с мах
{
     max = inputNum3; //принимаем за мах число 3
}
Console.WriteLine("Наибольшее из введённых чисел -> " + max); //вывод данных
