int AccermanFunction (int m, int n)
{
    int result = 0;
    if (m == 0) result = n + 1;
    else if(m > 0 && n == 0) result = AccermanFunction(m - 1, 1); 
    else if(m > 0 && n > 0) result = AccermanFunction(m - 1, AccermanFunction(m, n - 1));
    return result;
}
int firstArgument = 1;
int secondArgument = 2;
Console.WriteLine(AccermanFunction(firstArgument, secondArgument));