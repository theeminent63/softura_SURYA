using System;
class task3
{
public static void Main()
{
int[]marks=new int[5];
Console.WriteLine("Enter The Marks:");
for(int i=0;i<5;i++)
{
marks[i]=Convert.ToInt32(Console.ReadLine());
}
int sum=0,per;
for(int i=0;i<marks.Length;i++)
{
sum=sum+marks[i];
}
Console.WriteLine("Sum of Five Marks is:{0}",sum);
per = (sum*100)/500;
Console.WriteLine("Average of Five Marks is:{0}",per);
}
}