// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

void NaturalNumber(int m, int n){
    if(m == n+1)return;
    Console.Write($"{m} ");
    NaturalNumber(m+1, n);
}

int[] Array(int m, int n){
    int[] array = new int[(n-m)+1];
    int Summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = m+i;
        
    }
    return array;
}
int SummNumber(int[] arr){
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }
    return res;
}

int[] array = Array(M,N);
int result = SummNumber(array);
Console.WriteLine(result);
NaturalNumber(M,N);