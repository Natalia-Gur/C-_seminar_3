void Zadacha21()
{
    //Напишите программу, которая принимает на вход координаты двух точек и
    //находит расстояние между ними в 3D пространстве.
    Console.WriteLine("Введите координаты точки A");
    Console.Write("Ax: ");
    double Ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ay: ");
    double Ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("Az: ");
    double Az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Координата точки A ({Ax}, {Ay}, {Az})");

    Console.WriteLine("Введите координаты точки B");
    Console.Write("Bx: ");
    double Bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("By: ");
    double By = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bz: ");
    double Bz = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Координата точки A ({Bx}, {By}, {Bz})");

    double dist = Math.Sqrt(Math.Pow(Ax-Bx, 2) + Math.Pow(Ay-By, 2) + Math.Pow(Az-Bz, 2));
    Console.WriteLine($"Расстояние между точками: {Math.Round(dist, 3)}");
}

Zadacha21();