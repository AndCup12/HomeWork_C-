// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] ArrayNumbers(int Num){
    int[] array = new int[Num];
    
        for (int i = 0; i < Num; i++)
        {
            Console.WriteLine($"Введите значение {i} элемента массива");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    return array;
}

// void PrintArray(int[] arr){
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i == 0) Console.Write("[");
//         if(i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i] + "]");
//     }
// }

int CheckSizeNumber(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

void PrintResult(int[] arr, int Num){
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write($"{arr[i]}] -> {Num}");
    }
}

int[] array = ArrayNumbers(6);
int SizeNum = CheckSizeNumber(array);
PrintResult(array, SizeNum);
