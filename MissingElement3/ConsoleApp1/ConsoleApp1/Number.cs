using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Number
    {
        public List<int> list1;
        public List<int> list2;

        public void GetMissValue(Number list)
        {
            if (list.list1.Count > list.list2.Count)
            {
                Console.WriteLine(Value(list.list1, list.list2, 0, 0));
            }
            else
            {
                Console.WriteLine(Value(list.list2, list.list1, 0, 0));
            }
        }
        private int Value(List<int> list1, List<int> list2, int index1, int index2)
        {
            if (index2 < list2.Count)
            {
                if (list1[index1] != list2[index2])
                {
                    return Value(list1, list2, index1, index2 + 1);
                }
                else
                {
                    list2.Remove(list2[index2]);
                    return Value(list1, list2, index1 + 1, 0);
                }
            }
            else
            {
                return list1[index1];
            }
        }
    }
}
