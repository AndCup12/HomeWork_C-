Console.WriteLine("Введите координаты точки А через пробел (x, y, z): ");
int [] xyzA = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine("Введите координаты точки B через пробел (x, y, z): ");
int [] xyzB = Console.ReadLine().Split().Select(int.Parse).ToArray();

double Distance(int[] xyzA1, int[] xyzB1){
    int kat1;
    int kat2;
    int kat3;
    double result;

    kat1 = Math.Abs(xyzB1[0]) - Math.Abs(xyzA1[0]);
    kat2 = Math.Abs(xyzB1[1]) - Math.Abs(xyzA1[1]);
    kat3 = Math.Abs(xyzB1[2]) - Math.Abs(xyzA1[2]);

    result = Math.Sqrt(kat1 * kat1 + kat2 * kat2 + kat3 * kat3);
    return Math.Round(result, 2);
}

double result = Distance(xyzA, xyzB);
Console.WriteLine($"Расстояние между точками А и В: {result}");
