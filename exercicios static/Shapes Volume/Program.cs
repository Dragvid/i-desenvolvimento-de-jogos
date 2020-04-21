using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ip = new string[10];
            string[] operation = new string[10];
            int indx = 0;
            double[] res = new double[10];
            while (ip[indx - 1] != "End")
            {
                ip[indx] = Console.ReadLine();
                operation = ip[indx].Split(' ');
                if (operation[0] == "TriangularPrism")
                {
                    res[indx] = TrianglePrism.resul(Int32.Parse(operation[1]), Int32.Parse(operation[2]), Int32.Parse(operation[3]));
                }
                if (operation[0] == "cube")
                {
                    res[indx] = cube.resul(Int32.Parse(operation[1]));
                }
                if (operation[0] == "cylinder")
                {
                    res[indx] = cylinder.resul(Int32.Parse(operation[1]), Int32.Parse(operation[2]));
                }
                indx++;
            }
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
