using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    [Serializable]
    class Employee
    {
        public String EmployeeID = "VBNM";
        public String Name = "Ronaldo";
        public String Gen = "Male";
        public int age = 15;
    }
    class day12t2
    {
        public void SeritoFile()
        {

            Employee Eobj = new Employee();
            FileStream fs = new FileStream("Details.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, Eobj);
            fs.Close();
        }
        public void DesrialData()
        {
            FileStream fs = new FileStream("Details.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter f = new BinaryFormatter();
            Employee Ebj = (Employee)f.Deserialize(fs);
            Console.WriteLine(Ebj.Name);
            Console.WriteLine(Ebj.EmployeeID);
            Console.WriteLine(Ebj.Gen);
            Console.WriteLine(Ebj.age);
        }


        public static void Main()
        {
            day12t2 obj = new day12t2();
            obj.SeritoFile();
            obj.DesrialData();

            Console.ReadLine();


        }

    }
}
