// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] FillArray(int rows,int coloumns)
{
    int [,] arr = new int [rows,coloumns];
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
    return arr;
}
void PrintArray (int [,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}
int [,] array = FillArray (3,2);
PrintArray(array);
Console.WriteLine();

int minsum=Int32.MaxValue;
int index=0;
for (int i=0; i<array.GetLength(0); i++)
    {   int sum=0;
        for (int j=0; j<array.GetLength(1); j++)
        {
            sum =sum+array[i,j];  
        }    
            if (sum<minsum)
                {
                 minsum=sum;
                 index++;
                }    
    }

    Console.WriteLine ($"Строка с наименьшей суммой элементов под индексом " + index + " и с суммой " + minsum);




