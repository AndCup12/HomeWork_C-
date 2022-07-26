// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[,] values = new double[2,2];
double[] point = new double[2];

void FillValues(){
    for (int i = 0; i < values.GetLength(0); i++)
    {
        Console.Write($"Введите значения {i + 1}-го уравнения");
        for (int j = 0; j < values.GetLength(1); j++)
        {
            if(j==0) Console.Write($"Введите значение k: ");
            else Console.Write($"Введите значение b: ");
            values[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] ResultPoint(double[,] values){
    point[0] = (values[1,1] - values[0,1]) / (values[0,0] - values[1,0]); // значение X
    point[1] =  point[0] * values[0,0]  + values[0,1]; // значение Y
    return point;
}

void Result(double[,] values){
  if (values[0,0] == values[1,0] && values[0,1] == values[1,1]) {
    Console.WriteLine($"Прямые совпадают");
  }
  else if (values[0,0] == values[1,0] && values[0,1] != values[1,1]) {
    Console.WriteLine($"Прямые параллельны");
  }
  else {
    ResultPoint(values);
    Console.WriteLine($"Точка пересечения прямых: ({point[0]}, {point[1]})");
  }
}

FillValues();
Result(values);