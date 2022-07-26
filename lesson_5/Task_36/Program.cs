// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = new int[8];
Random rdn = new Random();

void FillArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rdn.Next(1, 50);
        Console.Write($"{arr[i]} ");
    }
}

void Sum(int[] arr){
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(i % 2 != 0 ){
            sum += arr[i];
        }
    }
    Console.WriteLine(sum);
}

FillArray(array);
Console.WriteLine();
Sum(array);