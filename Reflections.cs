using System;
using System.Reflection;
public class Student
{
    private string name;
    public int marks=0;
    private int id;
    public Student(string s, int n, int m)
    {
        name = s;
        id = n;
        marks=m;
    }
    public Student()
    {
        name = "NULL";
        id = 0;
    }

    public string Name
    {
        get;
        set;
    }
    public int Id
    {
        get;
        set;
    }
    public void Display()
    {
        Console.WriteLine($"Name-{name}");

        Console.WriteLine($"Id-{id}");
        Console.WriteLine($"Marks-{marks}");

    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Student s = new Student();
            Type t = s.GetType();
            Console.WriteLine(t);
            Assembly f = t.Assembly;
            Console.WriteLine($"Assembly-{f}");
            bool b = t.IsClass;
            Console.WriteLine($"Is it class-{b}");
            bool b1 = typeof(Student).IsSealed;
            Console.WriteLine($"Is sealed-{b1}");
            Console.WriteLine($"Name-{ t.Name}");
            Console.WriteLine($"Namespace-{t.Namespace}");
            Console.WriteLine($"Assembly Qualified Name{t.AssemblyQualifiedName}");
            Console.WriteLine($"Attributes-{t.Attributes}");
            Console.WriteLine($"Base Type-{t.BaseType}");
            Console.WriteLine($"Public Methods in Students-");
            Console.WriteLine("-------------------------------");
            var p = t.GetMethods();
            foreach(var i in p)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n-------------------------------");
            Console.WriteLine($"Fields in Student-");
            var q = t.GetFields();
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }
            
            var r = t.GetProperties();
            Console.WriteLine("\n\n-------------------------------");
            Console.WriteLine($"Properties in Student-");
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }



        }
    }
}
