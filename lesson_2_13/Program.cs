Console.WriteLine("Введите число");
string num = Console.ReadLine();
int result = Convert.ToInt32(num);

if(result > 100){
    char[] arr = num.ToCharArray();
    Console.WriteLine(arr[2]);
}else{
    Console.WriteLine("Третьей цифры нет");
}


