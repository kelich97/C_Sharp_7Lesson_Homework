// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


int[,] CreateArray()
{
    int m = 3;
    int n = 4;
    Console.WriteLine("Input min value");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
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


int [,] FindElem (int [,] array)
{
    Console.WriteLine("Input rows position ");
    int rows = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input colls position ");
    int colls = Convert.ToInt32(Console.ReadLine());
    //int [,] count = new int [0,0];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i,j]);
            if((i == rows) && (j == colls)) 
            {
                Console.WriteLine(array[i,j]);
            }
            else 
            {
                Console.WriteLine("Такого числа в массиве нет");
            }
        }

    }
    return array;
}


int [,] createArray = CreateArray();
ShowArray(createArray);
FindElem(createArray);





