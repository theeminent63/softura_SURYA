using System;
abstract class Benefits
{
public abstract void Silver();

public abstract void Gold();

public abstract void Platinum();

class impl:Benefits
{
public override void Silver()
{
Console.WriteLine("3 day's accomodation at Resort");
}
public override void Gold()
{
Console.WriteLine("5 day's accomodation at Resort & 2 Dinners on the house");
}
public override void Platinum()
{
Console.WriteLine("7 day's accomodation at Resort & 5 Dinners on the house");
}
}
class abslmple
{
public static void Main()
{
impl obj = new impl();
obj.Silver();
obj.Gold();
obj.Platinum();
}
}
}
