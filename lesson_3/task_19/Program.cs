Console.Write("Введи число: ");
string number = Console.ReadLine();

void CheckNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - не палиндром.");
}

if (number.Length == 5){
  CheckNumber(number);
}
else Console.WriteLine("Введи правильное число");


   


    