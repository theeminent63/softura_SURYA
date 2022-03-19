using System;
public abstract class Arith
{
public abstract void Add(int n1,int n2);
public abstract void Sub(int n1,int n2);
public abstract void Mul(int n1,int n2);
public abstract void Div(int n1,int n2);
}
class Operations:Arith
{
public override void Add(int n1,int n2)
{
int res=n1+n2;
Console.WriteLine("Addition is : "+res);
}
public override void Sub(int n1,int n2)
{
int res=n1-n2;
Console.WriteLine("Sub is :"+res);
}
public override void Mul(int n1,int n2)
{
int res=n1*n2;
Console.WriteLine("Using Mul is :"+res);
}
public override void Div(int n1,int n2)
{
double res=(float)n1/n2;
Console.WriteLine("Using Div is :"+res);
}
}
class Calculator
{
public static void Main()
{
Operations obj=new Operations();
Console.WriteLine("Enter The Numbers : ");
int n1=Convert.ToInt32(Console.ReadLine());
int n2=Convert.ToInt32(Console.ReadLine());
obj.Add(n1,n2);
obj.Sub(n1,n2);
obj.Mul(n1,n2);
obj.Div(n1,n2);
}
}