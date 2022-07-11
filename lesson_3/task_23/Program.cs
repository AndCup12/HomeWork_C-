Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result;

while(count <= N){
    result = count * count * count;
    Console.WriteLine($"{count, 3} -> {result, 3}");
    count++; 
}

