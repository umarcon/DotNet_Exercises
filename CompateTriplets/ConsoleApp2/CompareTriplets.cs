using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CompareTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int count = a.Count();
            int alice = 0;
            int bob = 0;

            for (int i = 0; i < count; i++)
            {
                int aValue = Convert.ToInt32(a[i].ToString());
                int bValue = Convert.ToInt32(b[i].ToString());

                if (aValue > bValue)
                {
                    alice++;
                }

                if (bValue > aValue)
                {
                    bob++;
                }
            }

            return new List<int> { alice, bob };
        }
    }
}
