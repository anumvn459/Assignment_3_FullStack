using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_FullStack
{
    internal class Assignment_2
    {
        class Shapes  // Base class (parent) 
        {
            public virtual void polygon()
            {
                Console.WriteLine("Diffrent types of Polygons");
            }
        }

        class Triangle : Shapes  // Derived class (child) 
        {
            public override void polygon()
            {
                Console.WriteLine("No of sides in a Triangle:3");
            }
        }

        class Pentagon : Shapes  // Derived class (child) 
        {
            public override void polygon()
            {
                Console.WriteLine("No of sides in a Pentagon is :5");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Shapes myShapes = new Shapes();  // Create a Shapes object
                Shapes myTriangle = new Triangle();  // Create a Triangle object
                Shapes myPentagon = new Pentagon();  // Create a Pentagon object

                myShapes.polygon();
                myTriangle.polygon();
                myPentagon.polygon();
            }
        }
    }
}
    

