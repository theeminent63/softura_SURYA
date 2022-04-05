using System;
class Age
{
int NumProperty;
public Age(int nProperty)
{
NumProperty = nProperty;
Console.WriteLine("Constructor level 1 Age : "+NumProperty);
}
}
class Name:Age
{
String Parameter;
public Name(String str, int n):base(n)
{
Parameter = str;
Console.WriteLine("Constructor level 2 Name : "+Parameter);
}

class impleCons
{
public static void Main()
{
Name obj1 = new Name("Surya",13);
}
}
}
