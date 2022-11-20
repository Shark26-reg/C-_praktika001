// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите 1е число > ");    // Вывод приглашения ввода
string inputnum_A = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int num_A = Convert.ToInt32(inputnum_A);        // Преобразование строки в число

Console.Write("Введите 2е число > ");    
string inputnum_B = Console.ReadLine();
int num_B = Convert.ToInt32(inputnum_B);

if (num_A > num_B)
{
   System.Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B); 
}
else
{
    System.Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A); 
}
