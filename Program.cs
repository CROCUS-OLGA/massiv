// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
//  Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     array[i] = new Random().Next(0, 101); //[1;100]
// }
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (int i = 0; i < n; i++)
// {
//     if ((array[i] >= 20) && (array[i] <= 90))
//     {
//         count = count + 1;
//         Console.Write(array[i] +",  ");
//     }
// }
// Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20,90]  " + count);
// if (count == 0)
//     Console.WriteLine("нет");
//-----------------------------------------------------------
// Задача 2: Задайте массив на 10 целых чисел.
//  Напишите программу, которая определяет количество
//   чётных чисел в массиве.
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
//     {
//     array[i] = new Random().Next(); 
//     }
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (int i = 0; i < n; i++)
// {
//     if ((array[i]%2==0))
//         count = count+1;
// }                
// Console.Write(count);  
//----------------------------------------------     
//  Задача 3: Задайте массив из вещественных чисел
//  с ненулевой дробной частью. Найдите разницу
//  между максимальным и минимальным элементов массива.
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// for (int i = 0; i < n; i++)
//     {
//     array[i] = new Random().NextDouble(); 
//     }
// Console.WriteLine(string.Join(", ", array));
// double minValue= array.Min();
// double maxValue= array.Max();
// double dif= maxValue-minValue;
// Console.WriteLine("Минимальный элемент:  "+ minValue);
// Console.WriteLine("Максимальный элемент:  "+ maxValue);
// Console.WriteLine("разница между ними: " + dif);