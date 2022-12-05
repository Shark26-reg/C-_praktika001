// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// int SumNumbers(int number)
// {
//     int sum = 0;

//     For(int i = 1; i <= number; i++)
//     {
//         sum += i;
//     }
//     return sum;
//}
int SumGaussNumbers(int number)
{
    return (1 + number) * number / 2;
}



int number = Prompt("Введите число > ");
// int result = SumNumbers(number);
// System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {result}");
// int result2 = SumForNumbers(number);
// System.Console.WriteLine($"Сумма (for) чисел от 1 до {number} равна {result2}");
int result3 = SumGaussNumbers(number);
System.Console.WriteLine($"Сумма (Гаусс) чисел от 1 до {number} равна {result3}");


