int N = Convert.ToInt32(Console.ReadLine());

int count = 2;
if (N < 2) Console.WriteLine("Something wrong...");
else
{
    while (count < N)
    {
        Console.WriteLine(count);
        count += 2;
    }
    N %= 2;
    if(N == 0) 
    Console.WriteLine(N);
}
