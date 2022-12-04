//Считываем данные с консоли
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
   //остаток от деления
    int lastDigit = inputNumber % 10;
    Console.WriteLine(lastDigit);
}
