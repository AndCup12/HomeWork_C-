// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int row, int col){
    Random rnd = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void SortRowMatrix(int[,] array){
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int Sup = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = Sup;
        }
      }
    }
  }
}

void PrintArray(int[,]arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < arr.GetLength(1) - 1) Console.Write(arr[i,j] + ",");
            else  Console.Write(arr[i,j] + "]");
        }
        Console.WriteLine();
    }
}

int [,] array = CreateMatrix(5,5);
PrintArray(array);
Console.WriteLine();
SortRowMatrix(array);
PrintArray(array);
