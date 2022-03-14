using System;
class Covid
{
public static void Main()
{
string str,str1,str2;
Console.WriteLine("Covid Checker");
Console.WriteLine("Do You Have Travel History");
str=Console.ReadLine();
if(str=="Yes")
{
Console.WriteLine("Do You Have Temperature?");
str1=Console.ReadLine();
if(str1=="Yes")
{
Console.WriteLine("Do You Have Cough/Snee?");
str2=Console.ReadLine();
if(str2=="Yes")
{
Console.WriteLine("Swab Test");
}
else
{
Console.WriteLine("Quarantine,Fever Medicine");
}
}
else
{
Console.WriteLine("Home Quarantine for 28 Days");
}
}
else
{
Console.WriteLine("Safe not COVID-19");
}
}
}