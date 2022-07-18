Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;

int Step(int a, int b){
    for (int i = 0; i < b; i++){
    result = result * a;
    }
    return result;
}

int res = Step(A, B);
Console.WriteLine($"{A} в степени {B} = {res}");