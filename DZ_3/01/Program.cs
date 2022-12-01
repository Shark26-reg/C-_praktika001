// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void PalindromNum(int number)
{
    if(number >= 10000 && number <= 99999)                                   // проверка введеного значения на корректность условию задачи
    {
        int firstNum  = number / 10000;                   // находим первую цифру
        int lastNum  = number % 10;                         // находим вторую цифру с конца
 
            if(firstNum  == lastNum )                       // проверяем совподают ли эти цифры, если да то переходим к сравнению следующей пары цифр
            {
                number = number / 10;                       //переход к следующей цифре
                int firstNum1  = (number / 100) % 10;
                int lastNum1 = number % 10;
                if(firstNum1  == lastNum1)
                    Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            
    }
    else
    Console.WriteLine("Введено не пятизначное число!");
}
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
PalindromNum(number);