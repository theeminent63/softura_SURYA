using System;
class task1
{
public static void Main()
{
Console.WriteLine("Enter your name and age");
string name = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());

for(int i=0;i<age;i++)
{
Console.WriteLine("your name is :"+name);
}
}
}
