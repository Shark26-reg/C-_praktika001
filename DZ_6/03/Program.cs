// Задача 5: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное 
// значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2



int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[,] FillCreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
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

int MaximusRows(int[,] matr)
{
    int summ = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int max = int.MinValue;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > max) max = matr[i, j];
        }
        summ += max;

    }
    return summ;
}

int MinColoums(int[,] matr1)
{
    int summin = 0;
    for (int i = 0; i < matr1.GetLength(1); i++)
    {
        int min = int.MaxValue;
        for (int j = 0; j < matr1.GetLength(0); j++)
        {
            if (matr1[j, i] < min) min = matr1[j, i];
        }
        summin += min;

    }
    return summin;
}


int Rows = Prompt("Input number of rows >");
int Coloums = Prompt("Input number of coloums >");
int[,] array = FillCreateArray(Rows, Coloums);
int maximus = MaximusRows(array);
int minimum = MinColoums(array);
int rezult = maximus - minimum;
PrintArray(array);
Console.WriteLine($"Самма максимальных элементов в строках массива = {MaximusRows(array)}");
Console.WriteLine($"Сумма минимальных элементов в столбцах массива  = {MinColoums(array)}");
System.Console.WriteLine($"Разница между суммой макс элементов и суммой минимальных элементов = {rezult}");



