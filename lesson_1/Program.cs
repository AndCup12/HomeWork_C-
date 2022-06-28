// Задача 2.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if(max > b){
    Console.WriteLine(max + " является максимальным числом");
}else{
    max = b;
    Console.WriteLine(max + " является максимальным числом");
}


// Задача 4.

int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int Max = num_1;

if(num_2 > Max){
    Max = num_2;
}if(num_3 > Max){
    Max = num_3;
}

Console.WriteLine(Max + " является максимальным числом");

// Задача 6.

int firstNum = Convert.ToInt32(Console.ReadLine());
 if(firstNum % 2 == 0){
    Console.WriteLine("Число " + " является четным");
 } else{
    Console.WriteLine("Число " + " не является четным");
 }

// Задача8.

int N = Convert.ToInt32(Console.ReadLine());
int Count = 1;

while(Count < N){
    if(Count % 2 == 0){
        Console.Write($"{Count} ");
    }
    Count++;
}

// Задача 7.

int Num = Convert.ToInt32(Console.ReadLine());

if(Num < 100){
    Console.WriteLine("Введите трехзначное число");    
}else{
    int result = Num % 10;
    Console.WriteLine(result);
}
