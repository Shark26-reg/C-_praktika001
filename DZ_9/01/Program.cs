// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    if (number % 2 == 0)
    
    System.Console.Write($"{number}; ");
    PrintNumbers(number - 1);       
}

int number = Prompt("Введите число ");
PrintNumbers(number);

