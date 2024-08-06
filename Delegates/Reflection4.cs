using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    // class Shape
    public class Shape
    {

        // Function that gives the name of the 
        // shape based on the number of sides
        // the number of sides is a string that
        // contains the value
        public String shapeName(String sideNumber)
        {
            if (sideNumber == "0" || sideNumber == "1" || sideNumber == "2")
                return "Not Valid";
            else if (sideNumber == "3")
                return "Triangle";
            else if (sideNumber == "4")
                return "Quadrilateral";
            else
                return "Polygon";
        }

    } // end Shape

    internal class Reflection4
    {
        static void Main()
        {
            Assembly executable = Assembly.GetExecutingAssembly();

            // To find the type of the class
            Type shapeType = executable.GetType("Geometry.Shape");

            // To create an instance of Shape class
            // without prior information about it
            object shapeObject = Activator.CreateInstance(shapeType);

            // To find the info about the method
            MethodInfo shapeNameMethod = shapeType.GetMethod("shapeName");
            // Prepare parameters for the method
            String[] param = new String[1];
            param[0] = "3";

            // To invoke the method using Invoke
            String sName = (String)shapeNameMethod.Invoke(shapeObject, param);

            // To display the name of the shape
            Console.WriteLine("Name of the Shape is {0}", sName);

        }
    }
}
