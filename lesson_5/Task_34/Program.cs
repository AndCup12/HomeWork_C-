//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] array = new int [10];
Random rdn = new Random();

void FillPrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rdn.Next(100,999);
        Console.Write($"{arr[i]} ");
    }
}

void Counter(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0){
            count++;
        }
    }
    Console.WriteLine($"-> {count}"); 
}
Console.Write("[ ");
FillPrintArray(array);
Console.Write("]");
Counter(array);