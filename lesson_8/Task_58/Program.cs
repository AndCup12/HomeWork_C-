// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int[,] CreateMatrix(int row, int col){
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,5);
        }
    }
    return array;
}

int[,] GreatMatrix(int[,] arr1, int[,] arr2){
    int[,] array = new int[arr1.GetLength(0),arr2.GetLength(1)];
    double Size = Math.Sqrt(arr1.GetLength(0) * arr2.GetLength(1));
    //  if(arr1.GetLength(1)==arr2.GetLength(0)){
        for (int i = 0; i < arr1.GetLength(1); i++)
        {
            for (int j = 0; j < arr2.GetLength(0); j++)
            {
                for (int k = 0; k < Size; k++)
                {
                    array[i,j] += arr1[i,k] * arr2[k,j]; 
                }
            }
        }
    // }
    return array;
}

bool MultiplyOrNot(int[,] arr1, int[,] arr2){
    int col = arr1.GetLength(1);
    int row = arr2.GetLength(0);
    if(col == row) return true;
    else return false;
}

void PrintResult(bool str, int[,] matr){
    if(str == true){
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            if(j == 0) Console.Write("[");
            if(j < matr.GetLength(1) - 1) Console.Write(matr[i,j] + ",");
            else  Console.Write(matr[i,j] + "]");
            }
            Console.WriteLine();
        }
    }else{
        Console.WriteLine("Нельзя перемножить матрицы");
    }
}


int[,] matrix1 = CreateMatrix(3,3);
PrintMatrix(matrix1);
int[,] matrix2 = CreateMatrix(3,3);
PrintMatrix(matrix2);
bool check = MultiplyOrNot(matrix1, matrix2);
int[,] greatMatrix = GreatMatrix(matrix1, matrix2);
PrintResult(check, greatMatrix);