// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


void PrintNumbers(int numberStart, int numberFinish)
{
    if (numberStart - 1 == numberFinish)
    {
        return;
    }
    if (numberFinish % 2 == 0)

    System.Console.Write($"{numberFinish};");    
    PrintNumbers(numberStart, numberFinish - 1);    
}
  
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int numberStart = Prompt("Введите число (начало промежутка) ");
int numberFinish = Prompt("Введите число (конец промежутка) ");
PrintNumbers(numberStart, numberFinish);

