// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] FillArray(int rows, int coloumns)
{
    int [,] arr = new int [rows, coloumns];
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
return arr;
}
void PrintArray(int [,] arr)
{for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

    int [,] array = FillArray(3,3);
    Console.WriteLine("Массив до сортировки: ");
     PrintArray(array);

int [,] Sort (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1)-1; j++)
        {
            for (int a=0; a<array.GetLength(1)-1; a++)
            {
                if (array[i,a] < array [i, a+1])
                {
                    int step=0;
                    step = array[i,a+1];
                    array[i,a+1] = array[i,a];
                    array[i,a]= step;
                }
            } 
        }
    }
    return array;
}
Console.WriteLine();
int [,] matrix = Sort(array);
Console.WriteLine("Массив после сортировки: ");
PrintArray(matrix);
