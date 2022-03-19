using System;
class VAT{
public void Tax(double n1)
{
 double vat= (n1*20)/100;
 Console.WriteLine(vat);
}
}
class GST:VAT
{
 public void Tax2(double n1, double n2)
{
   double gst = (n1*n2)/100;
   Console.WriteLine(gst);
}
}
class tt:GST 
{
public static void Main()
{
  GST obj= new GST();
  obj.Tax(100);
  obj.Tax2(1000,12);
}
} 