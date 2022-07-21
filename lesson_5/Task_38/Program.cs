// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = new double [10];
double max;
double min;

Random rdn = new Random();

void FillArray(double[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rdn.NextDouble() * 100, 1);
        Console.Write($"{arr[i]} ");
    }
}

void MinMax(double[] arr){
    max = arr[0];
    min = arr[0];
    for (int i = 1; i < arr.Length; i++){
       if(max < arr[i]) {max = arr[i];} 
       if(min > arr[i]) {min= arr[i];}
    }
    Console.WriteLine($"Минимальное число: {min} Максимальное число: {max}");
    double result = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным числом: {Math.Round(result, 1)}");
}
FillArray(array);
Console.WriteLine();
MinMax(array);

