using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.TretyakovDV.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = a - 150 == d | a + 5 > b;
            res[1] = a - 150 == d & a < c;
            res[2] = b - 2 == c || d + 5 < b;
            res[3] = c - 150 >= d && a < d;
            res[4] = !(!res[0]);
            res[5] = a - 150 == d ^ b > c;

            return res;
        }
    }
}
