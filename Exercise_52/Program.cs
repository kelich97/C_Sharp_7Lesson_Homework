//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateArray(int m, int n, int minValue, int maxValue)
{   
    int[,] array = new int [m,n];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;

} 

void ShowArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {    
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FindSum (int [,] array, int m)
{ 
      
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double sum = 0; 
        for (int i = 0; i < array.GetLength(0); i++) 
        {   
            sum = sum + array[i,j];  
        }
        Console.Write(sum / m + " ");   
    }
    Console.Write(" ");
}        

Console.WriteLine("Input m value");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input n value");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min value");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value");
    int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] createArray = CreateArray(m, n, minValue, maxValue);
ShowArray(createArray);
FindSum(createArray, m);
