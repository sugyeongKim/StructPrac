using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPrac
{
    struct Point
    {
        public int x;
        public int y;
       
    }

    struct PointStruct
    {
        public int x;
        public int y;
        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Pointclass
    {
        public int x;
        public int y;
        public Pointclass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point;
            point.x = 10;
            point.y = 10;
            Console.WriteLine("X: " + point.x);
            Console.WriteLine("Y: " + point.y);

            Pointclass pointclassA = new Pointclass(10, 20);
            Pointclass pointclassB = pointclassA;

            pointclassB.x = 100;
            pointclassB.y = 200;

            Console.WriteLine("pountClassA: " + pointclassA.x + ", " + pointclassA.y);
            Console.WriteLine("pountClassB: " + pointclassB.x + ", " + pointclassB.y);
            Console.WriteLine("");

            //구조체
            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;

            pointStructB.x = 100;
            pointStructB.y = 200;

            Console.WriteLine("pointStructA: " + pointStructA.x + ", " + pointStructA.y);
            Console.WriteLine("pointStructB: " + pointStructB.x + ", " + pointStructB.y);




        }
    }
}
