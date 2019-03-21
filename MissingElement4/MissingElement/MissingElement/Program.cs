using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Number list = new Number();
            list.list1 = new List<int>() { 6,6,3 };
            list.list2 = new List<int>() { 6,3 };
            list.GetMissValue(list);
        }
    }
}
