// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1
// Колонка > 7
// 1, 7 -> такого числа в массиве нет


int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int indexrows = Prompt("Введите индекс строки > ") - 1;
int indexcoloums = Prompt("Введите индекс столбца > ") - 1;
int[,] Array = new int[5,7];
FillArray(Array);
PrintArray(Array);

if (indexrows < Array.GetLength(0) && indexcoloums < Array.GetLength(1)) Console.WriteLine("Под введенным индексом это число : "+ Array[indexrows, indexcoloums]);
else Console.WriteLine($"{indexrows}, {indexcoloums} -> введеный индекс не соответствует размеру массива");



