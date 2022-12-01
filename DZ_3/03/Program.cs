// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write($"{message} ->");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int number = Prompt("Введите число ");
int start = 1;

int mod = number;
if (mod < 0)
{
    mod = -mod;
}    
while(start <= mod)
{
    int cube = start * start * start;
    Console.WriteLine(cube);
    start += 1;
}