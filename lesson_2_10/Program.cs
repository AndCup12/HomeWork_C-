int num = Convert.ToInt32(Console.ReadLine());
int result;

if(num < 1000){
    if(num > 99){
        result = num % 100;
        result = result /10;
        Console.WriteLine(result);
    }else{
        Console.WriteLine("Введите трехзначное число");
    }
}else{
    Console.WriteLine("Введите трехзначное число");
}