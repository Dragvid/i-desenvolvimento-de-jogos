using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Math
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
                if (operation[0] == "sum") {
                    res[indx] = MathUtil.sum(Int32.Parse(operation[1]),Int32.Parse(operation[2]));
                }
                if (operation[0] == "subtract") {
                    res[indx] = MathUtil.subtract(Int32.Parse(operation[1]), Int32.Parse(operation[2]));
                }
                if (operation[0] == "multiply") {
                    res[indx] = MathUtil.multiply(Int32.Parse(operation[1]), Int32.Parse(operation[2]));
                }
                if (operation[0] == "divide")
                {
                    res[indx] = MathUtil.divide(Int32.Parse(operation[1]), Int32.Parse(operation[2]));
                }
                if (operation[0] == "percentage") {
                    res[indx] = MathUtil.percentage(Int32.Parse(operation[1]), Int32.Parse(operation[2]));
                }
                indx++;
            }
            for(int i=0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
