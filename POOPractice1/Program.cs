// Program by @dasshuii on gitHub

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();

            Console.WriteLine("Type Radius: ");

            myCircle.Radius = int.Parse(Console.ReadLine());

            Console.WriteLine(myCircle.ToString());
            Console.ReadLine();
        }
    }

    class Circle
    {
        // Variables
        private const double PI = 3.14;
        private double radius = 0;

        //Constructors
        public Circle(){}
        public Circle(double radius) { this.radius = radius; }

        // Getter/Setter

        public double Radius {
            get { return radius; }
            set { radius = value; }
        }

        //Methods
        public double Area() {
            return PI * radius * radius;
        }

        public double Perimeter()
        {
            return 2 * PI * radius;
        }

        //ToString
        public override string ToString()
        {
            return "My radius is: " + radius + '\n' + "My area is: " + Area() + '\n' + "My perimeter is: " + Perimeter(); 
        }

        //Destructor
        ~Circle() {
        }
    }
}
