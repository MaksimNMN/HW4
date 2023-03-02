

const int N = 5;

int[] Fibonacci = new int[N];

for( int i = 2; i < Fibonacci.Length; i++)
{
    Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];

}
Console.WriteLine(string.Join(",", Fibonacci));