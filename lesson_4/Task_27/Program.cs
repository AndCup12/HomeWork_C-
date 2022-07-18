int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numN){
    
    int counter = Convert.ToString(numN).Length;
    int step = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      step = numN - numN % 10;
      result = result + (numN - step);
      numN = numN / 10;
    }
   return result;
}

int sumNum = SumNumber(num);
Console.WriteLine($"Сумма чисел в числе {num} = {sumNum}");