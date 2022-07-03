Console.Write("Введите число А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число В ");
int B = Convert.ToInt32(Console.ReadLine());
if (B <= 0) Console.WriteLine("Ошибка степени числа");
else Console.WriteLine($"Число А в степени В равно {Math.Pow(A, B)}");