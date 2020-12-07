using System;
namespace TuplesTest
{
    interface Diesel
    {

        char Grade();
        float EnergyPerLt();
        void Details();

    }
    interface Engine
    {
        int Capacity();
        String Performance();
        void Details();
    }
    class TATA : Engine
    {
        private int max_capacity = 50;
        private string performance = "Excellent";
        public int Capacity()
        {
            return max_capacity;
        }
        public String Performance()
        {
            return performance;
        }
        public void Details()
        {
            Console.WriteLine($"This is TATA Motors Enginee Capacity {max_capacity}\nPerformance-{performance}");
        }
    }
    class JCB : Diesel
    {
        private char grade = 'A';
        private float energy = 33.6F;
        public char Grade()
        {
            return grade;

        }
        public float EnergyPerLt()
        {
            return energy;
        }
        public void Details()
        {
            Console.WriteLine($"This Is JCB DIESEL With Garde-{grade}\nEnergy is-{energy}MJ/Lt");
        }

    }
    class Car : Diesel, Engine
    {
        
            JCB d = new JCB();
            TATA t = new TATA();

        public int Capacity()
        {
            return t.Capacity(); 
        }

        public void Details()
        {
            t.Details();
            d.Details();
        }

        public float EnergyPerLt()
        {
            return d.EnergyPerLt();
        }

        public char Grade()
        {
            return d.Grade();
        }

        public string Performance()
        {
            return t.Performance();
        }
    }
    class Program
    {
        public static void Main(String [] args)
        {
            Car c = new Car();
            Console.WriteLine("This car Made");
            c.Capacity();
            c.EnergyPerLt();
            c.Details();
            c.Grade();
            c.Performance();
        }
    }




}
