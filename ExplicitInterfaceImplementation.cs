using System;
using System.Collections;
using System.Collections.Generic;
public class DataBank : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        for(int i=0;i<200;i++)
        {
            if(i%5==0&&i%3==0)
            {
                yield return i;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
public interface Name
{
    void FullName();
}
public interface First
{
    int FullName();//can't performance method overloading becz return type only varey
}
public class Student:Name,First
{
    private String fullname;
    public int FullName()
    {
        Console.WriteLine($"Full Name is in First Interface-{fullname}");
        return 1;
    }
    void Name.FullName()
    {
        Console.WriteLine($"Full Name is in Name Interface Method-{fullname}");
    }
   
    

    public Student(String s)
    {
        fullname = s;
    }
}

class Program
{
    public static void Main(String [] args)
    {
        int[] a = { 10, 29, 34, 56, 23, 24, 53, 67 };
        Student s = new Student("Mallikarjuna");
        s.FullName();   //Error for Explicit Calling
        Name s1 = s;
        s1.FullName();
        ((Name)s).FullName();//Explicit Calling
        var bank = new DataBank();
        Console.WriteLine(bank);
        foreach (var item in bank)
        {
            Console.WriteLine(item);
        }
        var enumarator = bank.GetEnumerator();
        Console.WriteLine(enumarator);


    }
}
