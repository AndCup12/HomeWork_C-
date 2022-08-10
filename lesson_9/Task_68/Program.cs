// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Accerman(int m, int n){
    if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Accerman(m - 1, 1);
    else
      return Accerman(m - 1, Accerman(m, n - 1));
}

int res = Accerman(3,3);
Console.WriteLine(res);