using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingElement2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 13, 5, 6, 2, 5 };
            List<int> list2 = new List<int>() { 5, 2, 5, 13 };
            GetMissValue(list1, list2, 0, 0);
            
        }

        public static void GetMissValue(List<int> list1, List<int> list2, int index1, int index2)
        {
            if (index2 < list2.Count)
            {
                if (list1[index1] != list2[index2])
                {
                    GetMissValue(list1, list2, index1, index2 + 1);
                }
                else
                {
                    list2.Remove(list2[index2]);
                    GetMissValue(list1, list2, index1 + 1, 0);
                }
            }
            else
            {
                Console.WriteLine(list1[index1]);
            }
        }
    }
}
