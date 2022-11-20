//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.Write("Введите 1е число > ");    // Вывод приглашения ввода
string inputnum_A = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int num_A = Convert.ToInt32(inputnum_A);        // Преобразование строки в число

Console.Write("Введите 2е число > ");    
string inputnum_B = Console.ReadLine();
int num_B = Convert.ToInt32(inputnum_B);

Console.Write("Введите 3е число > ");    
string inputnum_C = Console.ReadLine();
int num_C = Convert.ToInt32(inputnum_C);

int max = num_A;
if (num_B > max)
{
   max = num_B;
}
if(num_C > max)
{
    max = num_C;
}
 System.Console.WriteLine("Максимальное из введённых чисел = " + max); 
 