using System;
class task3
{
public static void Main()
{
string Package;
Console.WriteLine("Enter The Package Name:");
Package=Console.ReadLine();
switch(Package)
{
case "A":Console.WriteLine("Rate For Package A is: Rs.250");
break;
case "B":Console.WriteLine("Rate For Package B is: Rs.450");
break;
case "C":Console.WriteLine("Rate For Package C is: Rs.350");
break;
default:Console.WriteLine("Choose The Correct  Package Name");
break;
}
}
}