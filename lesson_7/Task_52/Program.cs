// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] CreateMatrix(int row, int col){
    int [,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1, 9);
        }
    }
    return array;
}

int [] SumElementsColumn(int[,] arr){
    int [] array = new int[arr.GetLength(1)];
    
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                array[i] += arr[j,i];
            }
        }
        return array;
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
void PrintArray(int[] arr){
    Console.WriteLine("Сгенерированный массив из суммы элементов в столбцах: ");
    for (int i = 0; i < arr.Length; i++){
            if(i == 0) Console.Write("[");
            if(i < arr.Length-1) Console.Write($"{arr[i],4}");
            else  Console.Write($"{arr[i],4}]" );
        }
        Console.WriteLine();
}
void PrintDoubleArray(double[] arr){
    Console.WriteLine("Массив из среднего значения столбцов: ");
    for (int i = 0; i < arr.Length; i++){
            if(i == 0) Console.Write("[");
            if(i < arr.Length-1) Console.Write($"{arr[i],4} ");
            else  Console.Write($"{arr[i],4}] ");
        }
}

double[] AverageElements(int[] arr, int[,] array){
    double[] Arr = new double[arr.GetLength(0)];
    int countColumn = array.GetLength(0);
    for (int i = 0; i < arr.Length; i++)
    {
        Arr[i] = Math.Round((double)arr[i]/countColumn,1);
    }
    return Arr;
}

int[,] matrix = CreateMatrix(6,8);
PrintMatrix(matrix);
int [] array1 = SumElementsColumn(matrix);
PrintArray(array1);
double[] resArray = AverageElements(array1, matrix);
PrintDoubleArray(resArray);