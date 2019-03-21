using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingElement
{
    public class Number
    {
        public List<int> list1;
        public List<int> list2;

        public void GetMissValue(Number list)
        {
            if (list.list1.Count > list.list2.Count)
            {
                ValueOfDictonary(list.list1, list.list2);
            }
            else
            {
                ValueOfDictonary(list.list2, list.list1);
            }
        }
        public void ValueOfDictonary(List<int> list1, List<int> list2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (var index = 0; index < list2.Count; index++)
            {
                dict[index] = list2[index];
            }
            Compare(dict, list1);
        }
        public void Compare(Dictionary<int,int> dict, List<int> list1)
        {
            for (int index2 = 0; index2 < list1.Count; index2++)
            {
                if (!dict.ContainsValue(list1[index2]))
                {
                    Console.WriteLine(list1[index2]);
                }
                else
                {
                    foreach (var item in dict.Where(kvp => kvp.Value == list1[index2]).ToList())
                    {
                        dict.Remove(item.Key);
                    }
                }
            }
        }
    }
}
