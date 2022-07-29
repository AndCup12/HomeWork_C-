// Задайте двумерный массив размером M x N, заполненный случайными вещественными числами.

Console.WriteLine("Введите колличество строк массива: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrix(int row, int col){
    double[,] array = new double[row, col];
    Random rnd = new Random();
    int max = 15;
    int min = 2;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round((new Random().NextDouble() * (max - min) + min), 1);
        }
    }
    return array;
}

void PrintMatrix(double[,] arr){
    Console.WriteLine("Сгенерированный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < arr.GetLength(1) - 1) Console.Write($"{arr[i,j],4} ");
            else  Console.Write($"{arr[i,j],4}]" );
        }
        Console.WriteLine();
    }
}

double[,] resMatrix = CreateMatrix(M,N);
PrintMatrix(resMatrix);