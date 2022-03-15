using System;  
class task2  
{  
public static void Main() 
{
int j,n;
Console.Write("Display the multiplication table:\n");
Console.Write("Input the number (Table to be calculated) : ");
n= Convert.ToInt32(Console.ReadLine());   
Console.Write("\n");
for(j=1;j<=20;j++){
Console.Write("N * {1} = {1}N \n",n,j,n*j);
}
}
}