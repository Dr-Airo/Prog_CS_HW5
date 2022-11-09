// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите размер массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[len];
FillArray(numbers);
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($" Количество чётных чисел в массиве: {count} ");

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Console.WriteLine("Введите размер массива");
// int array = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[array];
// FillArray(numbers);
// PrintArray(numbers);
// int summ = 0;
// for (int i = 1; i<numbers.Length; i+=2)
// {
//     summ = summ + numbers[i];
// }
// Console.Write($"Сумма нечетных элементов массива равна {summ}");
// void FillArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(0,101);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Console.WriteLine("Введите размер массива");
// int array = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[array];
// FillArray(numbers);
// PrintArray(numbers);

// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int i = 0; i<numbers.Length; i++ )
// {
//     if (numbers[i]>max)
//     {
//         max = numbers[i];
//     }
//     if (numbers[i]<min)
//     {
//         min = numbers[i];
//     }
// }

// Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArray(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = Convert.ToDouble(new Random().Next(100,1000))/100;
//     }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

// Console.WriteLine("Введите размер массива");
// int array = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[array];
// FillArray(numbers);
// Console.WriteLine("Сгенерировали следующий массив");
// PrintArray(numbers);

// int min = Int32.MaxValue;
// int max = Int32.MinValue;
// int InMax = 0;
// int InMin = 0;
// for (int i = 0; i<numbers.Length; i++ )
// {
//     if (numbers[i]>max)
//     {
//         max = numbers[i];
//         InMax = i;
//     }
//     if (numbers[i]<min)
//     {
//         min = numbers[i];
//         InMin = i;
//     }
// }

// int summ = 0;
// int average = summ/numbers.Length;
// for (int i = 0; i<numbers.Length; i++ ) summ = summ+numbers[i];

// int [] sortarr = new int [] SortArray(numbers);
// int index = array/2;
// int mediana = sortarr[index];

// void FillArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(0,101);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// static int SortArray(int [] numbers)
// {
//     int temp;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         for (int j = i + 1; j < numbers.Length; j++)
//          {
//             if (numbers[i] > numbers[j])
//             {
//                 temp = numbers[i];
//                 numbers[i] = numbers[j];
//                 numbers[j] = temp;
//             }                   
//         }            
//     }
//     return numbers;
// }

// Console.Write($"Max = {max} , indexMax = {InMax}, Min = {InMin}, average = {average}");
// Console.Write($"Медианное значение первоначального массива= {mediana}");