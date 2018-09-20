using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

            //Task One 

        {
            Car c1 = new Car();
            c1.Make = "Jaguar";
            c1.Model = "Expo";
            c1.Colour = "Blue";
            c1.Rego = "DGH567";
            Console.WriteLine( c1.Model + " " c1.Make + "Colour"  );

            Car c2 = new Car();
            c2.Make = "Mazda";
            c2.Model = "cX";
            c2.Colour = "Black";
            c2.Rego = "KIT986";
            Console.WriteLine(Car c2());

            Car c3 = new Car();
            c3.Make = "Nissan";
            c3.Model = "Bluebird";
            c3.Colour = "Blue";
            c3.Rego = "JHY543";
            Console.WriteLine(Car c3());

            Car c4 = new Car();
            c4.Make = "Toyota";
            c4.Model = "Corolla";
            c4.Colour = "White";
            c4.Rego = "YUT670";
            Console.WriteLine(Car c4());

            Car c5 = new Car();
            c5.Make = "Nissan";
            c5.Model = "Primera";
            c5.Colour = "Red";
            c5.Rego = "UDB734";
            Console.WriteLine(Car c5());

        }

    }
     public class Car
    {
        public string make;
        public string model;
        public string colour;
        public string rego;
    
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }

        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }

        }
        public string Rego
        {
            get { return rego; }
            set { rego = value; }

        }

        //Task Two

        public class Person

        {
            public string fname;
            public string lname;
            private int age;

            public string Fname

            {
                get { return fname; }
                set { fname = value; }

            }

            public string Lname
            {
                get { return lname; }
                set { lname = value; }

            }

            private int Age

            {
               get { return age; }
                set { age = value; }

            }
            public Person (string_fna)
           


}
    }

}
