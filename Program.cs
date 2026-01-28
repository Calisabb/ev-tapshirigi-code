1. sade ve ya murekkeb. 
int n = Convert.ToInt32(Console.ReadLine());
if (n<=1)
{
    Console.WriteLine("not prime and not composite");
}
for (int i = 2; i<=Math.Sqrt(n); i++)
{
    if (n%i==0)
    {
        Console.WriteLine("Composite");
        break;
    }
    if (i<=Math.Sqrt(n))
    {
        Console.WriteLine("Prime");
        break;
    }
}
2. factorial
int m = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
while (m>0)
{
    factorial = factorial * m;
    m--;
}
Console.WriteLine(factorial);
3. 278 => 2+7+8=17 
int k = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (k>0)
{
    sum=sum+(k%10);
    k=k/10;
}
Console.WriteLine(sum);



