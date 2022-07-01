Console.WriteLine("Введите число");
string num = Console.ReadLine();
 int result = Convert.ToInt32(num);
int div;

if(result < 100){
    Console.WriteLine("Третьего числа нет");
}else{
    while(result > 999){
        result /= 10;
    }
    div = result % 10;
    Console.WriteLine(div); 
}


