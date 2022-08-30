// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int row=2;
int column=2;
int widch=2;
int [,,] array = new int [row,column,widch];

int indexRow=0;
int indexColumn=0;
int indexWidch=0;

for (int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        for (int k=0; k< array.GetLength(2); k++)
        {
            array[i,j,k] = new Random().Next(1,10);
            int x=array [i,j,k];
            indexRow++;
            indexColumn++;
            indexWidch++;
            if (array[i,j,k]==x)
            {
                array[i, j, k] = new Random().Next(9,100);
                Console.Write("Элемент трехмерного массива " + $"{array [i,j,k]}" );
                Console.Write (" c индексами (" + $"{indexRow}" + $"{indexColumn}" + $"{indexWidch}" + ");");
                Console.WriteLine();
            }
        }
    }

}
    

