Console.WriteLine("y = k1*x + b1");
Console.WriteLine("y = k2*x + b2");
Console.Write("Введите k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) 
    {
        if (b1 == b2) Console.WriteLine("Прямые совпадают");
        else Console.WriteLine("Прямые не пересекаются");
    }       
else
{
    double xCoordination = -Convert.ToDouble(b1 - b2) / Convert.ToDouble(k1 - k2);
    double yCoordination = xCoordination * k1 + b1;
    Console.WriteLine($"Координаты точки пересечения прямых ({xCoordination}; {yCoordination})");
}