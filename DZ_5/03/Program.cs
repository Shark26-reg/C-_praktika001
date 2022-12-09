// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void GenerateArray(double[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble (new Random().Next(0, 100)) / 10;
    }

}

void PrintArray(double[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}



System.Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
GenerateArray(array);

PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < array.Length; i++)
{
     if (array[i] > max)
         {
             max = array[i];
         }
     if (array[i] < min)
         {
             min = array[i];
         }
    
}


System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");


