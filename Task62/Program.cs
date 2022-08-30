// Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] array = new int [4,4];

for (int j=0; j<array.GetLength(1); j++)
{
    array [0,j] = new Random ().Next(1,2);
    Console.Write($"{array[0,j]} ");
    
}
Console.WriteLine();
for (int i =1; i< array.GetLength(0); i++)
{
    array[i,3] = new Random().Next(2,3);
    Console.WriteLine($"{array[i,3]} ");

    for (int j=2; j>=0; j--)
    {
    array[3,j] = new Random().Next(3,4);
    Console.Write($" {array[3,j]} ");
    }
}
for (int i=2; i>0; i--)
{
    array[i,0]= new Random().Next(4,5);
    Console.WriteLine($" {array[i,0]} ");
}
for (int j=1; j<array.GetLength(1)-1; j++)
{
    array[1,j] = new Random().Next(5,6);
    Console.Write($" {array[1,j]} ");
}
for (int j=2; j>0; j--)
{
    array[2,j] = new Random().Next(6,7);
    Console.Write($" {array[2,j]} ");
}


