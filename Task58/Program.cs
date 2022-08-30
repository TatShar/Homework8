// адайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] FillArray (int row, int column)
{
    int [,] arr = new int [row, column];
    for (int i=0; i< arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = new Random().Next(1,10);
        }
    }
    return arr;
}

void PrintArray (int [,] arr)
{
    for (int i=0; i< arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
int [,] arrayOne = FillArray(3,3);
PrintArray(arrayOne);
Console.WriteLine();

int [,] arrayTwo = FillArray(3,3);
PrintArray(arrayTwo);

int [,] MultiplyArray(int [,] arr1, int [,] arr2)
{
    int [,] ar = new int [arrayOne.GetLength(0),arrayOne.GetLength(1) ];
    for (int i=0; i< ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i,j] = arrayOne[i,j] * arrayTwo[i,j];
        }
    }
    return ar;
}
Console.WriteLine();
int [,] arrayMulty = MultiplyArray(arrayOne, arrayTwo);
PrintArray(arrayMulty);
