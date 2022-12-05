//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.


int num = Prompt("Введите число ->");
int len = NumberLen(num);
SumNumbers(num, len);



int Prompt(string message)                                                   //Функция ввода
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)                                             //Функция подсчета цифр в числе
{
    int index = 0;                                              
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int number, int len)                                  //Функция вывода суммы чисел в числе
{
    int sum = 0;
    for(int i = 1; i <= len; i++)
    {
        sum += number % 10;
        number /= 10;
        
    }
    Console.WriteLine($"Сумма цифр в числе {num} = {sum}");
}


