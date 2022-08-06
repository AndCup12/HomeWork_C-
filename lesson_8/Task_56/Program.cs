// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void PrintMatrix(int[,]arr){
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
    Console.WriteLine();
}

void PrintArray(int[]arr){
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < arr.Length - 1) Console.Write(arr[i] + ",");
        else  Console.Write(arr[i] + "]");
    }
    Console.WriteLine();  
}

int[,] CreateMatrix(int row, int col){
    int[,] array = new int[row,col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
    return array;
}

int[] SumElementsRow(int[,] arr){
    int[] array = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i] += arr[i,j];
        }
    }
    return array;
}

int RowMinimalSum(int[] arr){
    int min = arr[0];
    int count = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] <= min){
            min = arr[i];
            count = i;
        }
    }
    return count;
}

void PrintResult(int num){
    Console.WriteLine($"{num+1} строка содержит минимальную сумму элементов.");
}
int[,] matrix = CreateMatrix(5,5);
PrintMatrix(matrix);
int[] array = SumElementsRow(matrix);
PrintArray(array);
int row = RowMinimalSum(array);
PrintResult(row);
