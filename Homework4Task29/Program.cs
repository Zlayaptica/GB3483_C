// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
//v1
// Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
//             Console.Write("Введите любое число (A): ");
//             int enterNumber = Convert.ToInt32(Console.ReadLine());

//             int[] array = new int[enterNumber];

//             for (int i = 0; i < enterNumber; i++)
//             {
//                 array[i] = new Random().Next(enterNumber+1);
//                 Console.Write(array[i] + "; ");
//             }
//             Console.WriteLine();

//             //Вариант вывода вне цикла:
//             Console.WriteLine($"[{String.Join("; ", array)}]");
 
//v2

Console.WriteLine("Массив из 8 случайных целых чисел: "); 

int[] array = new int[8]; //создание случайного массива
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-8, 9);
    string number = Convert.ToString(array[i]);
    Console.Write("|" + number.PadLeft(4, ' ') + " ");
}
Console.WriteLine("|");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Отсортированный по модулю массив:");
Console.WriteLine("-------------------------------------------------");
int temp;
for (int i = 1; i < array.Length; i++)
    for (int j = 1; j < array.Length; j++)
    {
        if (Math.Abs(array[j - 1]) > Math.Abs(array[j]))
        {
            temp = array[j - 1];
            array[j - 1] = array[j];
            array[j] = temp;
        }
    }
for (int i = 0; i < array.Length; i++)
{
    string number = Convert.ToString(array[i]);
    Console.Write("|" + number.PadLeft(4, ' ') + " ");
}
Console.WriteLine("|");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("");
