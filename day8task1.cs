using System;
class basic
{
public void AddNos(int n1, int n2){
	int add = n1+n2;
	Console.WriteLine(add);
	int sub = n1-n2;
	Console.WriteLine(sub);
	}
class derived:basic
{
public void AddNos2(int n1, int n2){
	int mul = n1*n2;
	Console.WriteLine(mul);
	int div = n1/n2;
	Console.WriteLine(div);
	}
public static void Main(){
	derived obj = new derived();
	obj.AddNos(11,11);
	obj.AddNos2(22,22);
	}
}
}
