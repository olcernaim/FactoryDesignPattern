using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle Draw() method");
        }
    }
}
