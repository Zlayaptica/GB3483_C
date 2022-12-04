// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Считываем данные с консоли
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputNum1!=null&&inputNum2!=null)
{
//Перевод в целые числа
    int inputFull1=int.Parse(inputNum1);
    int inputFull2=int.Parse(inputNum2);
    
    //Проверка равенства чисел
    if (inputFull1==inputFull2)
    {
        Console.WriteLine("Введенные числа равны");
    }
    else
    {     //Проверяем условие, если первое число больше второго
        if (inputFull1>inputFull2)
        {
            Console.WriteLine(inputFull1 + " больше " + inputFull2);
        }
        else
        {
            Console.WriteLine(inputFull1 + " меньше " + inputFull2);
        }
    }
}