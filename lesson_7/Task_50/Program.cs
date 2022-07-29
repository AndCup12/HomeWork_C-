// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int[,] CreateMatrix(int row, int col){
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1, 15);
        }
    }
    return array;
}

string ReturnElement(int[,] arr, int row, int col){
    string result = string.Empty;
    if(row > arr.GetLength(0) & col > arr.GetLength(1)){
        result = ($"{row},{col} -> Такого числа нет, попробуйте снова");
    } else {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
           for (int j = 0; j < arr.GetLength(1); j++)
           {
            result = ($"Найденный элемент: " + arr[row-1, col-1]);
           }
        }
    }
    return result;
}

void PrintMatrix(int[,] arr){
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

int[,] resArray = CreateMatrix(4,4);
Console.WriteLine("Введите строку массива: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец массива: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintMatrix(resArray);
string result = ReturnElement(resArray, M, N);
Console.WriteLine(result);


