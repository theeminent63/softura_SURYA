using System;
class Task2
{
public static void Main()
{
int N;
Console.WriteLine("Enter the Number :");
N =Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=20;i++)
{
int P;
P = N * i;
Console.WriteLine("{0} * {1} = {2}",N,i,P);
}
}
}
