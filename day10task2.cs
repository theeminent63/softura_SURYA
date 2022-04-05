using System;
class Employee1
{
public void SandM()
{
Console.WriteLine("Sales & Marketing Department");
Console.WriteLine("Enter Emp_Name");
String Name = Console.ReadLine();
Console.WriteLine("Enter Gender");
String Gender = Console.ReadLine();
Console.WriteLine("Enter EmployeeID");
int EmployeeID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Year of Experience");
int YOfE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Salary");
int Salary = Convert.ToInt32(Console.ReadLine());
double bonus = Salary*0.2;

Console.WriteLine("Sales & Marketing Department\n"+"Name of the Employee is : "+Name+" EmployeeID is : "+EmployeeID+
		" Gender is : "+Gender+" Years Of Experience is : "+
 		 YOfE+" Salary is : "+Salary+" Bonus "+bonus);
}
}
class Employee2:Employee1
{

public void PD()
{
Console.WriteLine();
Console.WriteLine("Production Department");
Console.WriteLine("Enter Emp_Name");
String Name = Console.ReadLine();
Console.WriteLine("Enter Gender");
String Gender = Console.ReadLine();
Console.WriteLine("Enter EmployeeID");
int EmployeeID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Year of Experience");
int YOfE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Salary");
int Salary = Convert.ToInt32(Console.ReadLine());
double bonus = Salary*0.1;

Console.WriteLine("Production Department\n"+"Name of the Employee is : "+Name +" EmployeeID is : "+EmployeeID +
		" Gender is : "+Gender +" Years Of Experience is : "+
 		 YOfE+" Salary is : "+Salary+" Bonus "+bonus);
}
}
class imple
{
public static void Main()
{
Employee2 obj = new Employee2();
obj.SandM();
//obj.PD();
}
}
