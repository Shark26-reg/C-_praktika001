// Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных). Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5



int[] GenerateArray(int Length, int minRange, int maxRange)
{

    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}


int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int maxValueIndex(int[] array)
{
    int largest = 0, second = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        int arrItem = array[i];
        if (arrItem > largest)
        {
            second = largest;         //присваиваем значение самого большого 
                                     
            largest = arrItem;        //второе по величине
        }
        else if (arrItem > second && arrItem < largest)        //сравниваем полученные значения которые больше второго по величине и меньше самого большого
                                                                
            second = arrItem;
    }return second;
}    

    int Range = Promt("Введите длину массива ");
    int minValue = Promt("Введите минимальное значение ");
    int maxValue = Promt("Введите максимальное значение ");


    int[] arr = GenerateArray(Range, minValue, maxValue);
    PrintArray(arr);
    Console.WriteLine("Второй максимум массива равен: " + maxValueIndex(arr));




// int SecondMax (int [] array)
// {
//     int max = array[0];
//     int max2nd = int.MinValue;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array [i] >= max)
//         {
//             max = array[i];
//         }
//         if (array [i] < max && array[i] >= max2nd)
//         {
//             max2nd = array[i];
//         }
//     }
//     return max2nd;
// }
