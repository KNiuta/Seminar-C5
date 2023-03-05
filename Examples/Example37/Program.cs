/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
                [1 2 3 4 5] -> 5 8 3
                [6 7 3 6] -> 36 21 

int size = new Random().Next(11);
int[] array = GetArray(size,0,10);
Console.WriteLine($"Исходный массив:[{String.Join(";",array)}]");
int length = size/2+1;
int[] newArrayFirst = new int[length];
int[] newArraySecond = new int[length-1];

int[] GetArray(int size, int minValue, int maxValue)
{
 int[] result = new int[size];
 for (int i = 0; i<size; i++)
 {
     result[i] = new Random().Next(minValue,maxValue+1);
 }
 return result;
}
if(size%2==1)
{
  if(size==1)
  {
              newArrayFirst[0]=array[0];  
  }            
  else
  {        
       for (int i = 0; i < size/2; i++)
       {
         newArrayFirst[i]=array[i]+array[size-1-i];
         newArrayFirst[size/2]=array[size/2];     
       }
  }    
Console.WriteLine($"Преобразованный массив:[{String.Join(" ; ",newArrayFirst)}]");
}
else 
{
              for (int i = 0; i < size/2; i++)
{ 
         newArraySecond[i]=array[i]+array[size-1-i];   
} 
 Console.WriteLine($"Преобразованный массив:[{String.Join(" ; ",newArraySecond)}]"); 
 } */

int size = new Random().Next(11);
int[] array = GetArray(size,0,10);
Console.WriteLine($"Исходный массив:[{String.Join(";",array)}]");
int length = size/2+1;
int[] newArrayFirst = newArray(length, array,size);
int[] newArraySecond = newArray(length-1, array,size);


int[] GetArray(int size, int minValue, int maxValue)
{
 int[] result = new int[size];
 for (int i = 0; i<size; i++)
 {
     result[i] = new Random().Next(minValue,maxValue+1);
 }
 return result;
}
int[] newArray (int sizeResult,int[] array, int sizeArray)
{    
     int[] result = new int[sizeResult] ;      
     for (int i = 0; i < sizeArray/2; i++)
     {
          result[i]=array[i]+array[sizeArray-1-i];    
     } 
     return result;
}
if(size%2==1)
{
  if(size==1) 
  {
  Console.WriteLine($"Преобразованный массив:[{String.Join(" ; ",array)}]");    
  }        
  else 
  {
        newArrayFirst[size/2]=array[size/2]; 
        Console.WriteLine($"Преобразованный массив:[{String.Join(" ; ",newArrayFirst)}]");
   }
} 
else
{        
 Console.WriteLine($"Преобразованный массив:[{String.Join(" ; ",newArraySecond)}]");
}