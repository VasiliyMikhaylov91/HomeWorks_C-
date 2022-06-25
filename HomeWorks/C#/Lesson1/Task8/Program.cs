Console.Clear();
Console.Write("Введите целое число N = ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

if(N > 0) N = N + 1;
else N = N - 1;

while (count != N)
{
    if (count % 2 == 0)
     {
        Console.WriteLine(count);
     }
    if (N > 0) count++;
    
    else count--;
}