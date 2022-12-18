// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:"); //ввод данных
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];  //создание массива 
FillArrayRandomNumbers(numbers); 
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; 
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"Итого чисел: {numbers.Length}, из них чётных: {count}.");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]"); //вывод данных
    Console.WriteLine();
}