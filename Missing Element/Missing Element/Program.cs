using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int> { 14, 27, 1, 4, 2, 50, 3, 1 };
            var list2 = new List<int> { 2, 4, -4, 3, 1, 1, 14, 27, 50 };
            GeTMissingValue(list1, list2);
        }

        static void GeTMissingValue(List<int> list1, List<int> list2)
        {
            IEnumerable<int> list3;

            if (list1.Count() > list2.Count())
            {
                list3 = list1.Except(list2);
            }
            else
            {
                list3 = list2.Except(list1);
            }
            Console.WriteLine(list3.First());
        }
    }
}
