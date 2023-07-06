// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateArray()
{
    int m = 3;
    int n = 4;
    Console.WriteLine("Input min value");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double [m,n];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
    return array;

} 

void ShowArray (double[,] array)
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

double [,] array = CreateArray();
ShowArray(array);










