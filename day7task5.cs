using System;
class Jarray
{
public static void Main()
{
string [][] products = new string[3][];
products[0] = new string[] {"Treat","Gooday","Marry","parlay"}; 
products[1] = new string[] {"Galaxy","Dairymilk","Munch","kitkate","Snickers"};
products[2] = new string[] {"coke","pepsi","7up","dhumsup","sprite","redbull"};

for(int i=0;i<products.Length;i++)
{
	for(int j=0;j<products[i].Length;j++)
	Console.Write(products[i][j]+"\t");
	Console.WriteLine();
}
}
}
