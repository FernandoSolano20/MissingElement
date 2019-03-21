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
        {
            Number list = new Number();
            list.list1 = new List<int>() { 13, 5, 6, 2, 5 };
            list.list2 = new List<int>() { 5, 2, 5, 13 };
            list.GetMissValue(list);
        }
    }
}
