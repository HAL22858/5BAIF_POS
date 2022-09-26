// See https://aka.ms/new-console-template for more information
using System.Reflection;


Console.WriteLine("Hello, World!");


string s = "Hello World!!";

Student student = new Student();
student.FirstName = "Christoph";
student.LastName = "Halbauer";
student.Id = 1;

bool isEqual = student.Equals(new Student());

//Reflections
PropertyInfo[] properties = student.GetType().GetProperties();
foreach (PropertyInfo item in properties)
{
    Console.WriteLine(item.Name);
}
//Reflections

