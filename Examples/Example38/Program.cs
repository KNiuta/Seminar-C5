/* Задача 38: Задайте массив вещественных чисел. Найдите разницу 
              между максимальным и минимальным элементов массива.

                     [3 7 22 2 78] -> 76   */

double[] Array = new double[10];
var rand = new Random();
int size = Array.Length;

for (int i = 0; i < size; i++)
{
      Array[i] = rand.Next(100)+Math.Round(rand.NextDouble(),2);
} 
Console.WriteLine($"Массив:[{String.Join(" ; ",Array)}]");

 var min = Array[0];
 var max = Array[0];   
       for (int i = 0; i < size; i++)
       {
              if(Array[i]<min) min = Array[i];
       }
       for (int j = 0; j < size; j++)
       {
              if(Array[j]>max) max = Array[j];
       }
double result = max-min;  
Console.WriteLine($"Разность между максимальным и минимальным элементом массива:{max} - {min} = {result}");



        
       