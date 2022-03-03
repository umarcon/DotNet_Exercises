using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularArrayRotation
{
    public class CircularRotation
    {
        /*
         * Complete the 'circularArrayRotation' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER k
         *  3. INTEGER_ARRAY queries
         */
        public static int[] circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            int len = a.Count;
            int[] ans = new int[queries.Count];
            int[] tempArr = new int[a.Count];
            List<int> result;
            k = k % len;
            for (int i = 0; i < len; i++)
            {
                int index = (i + k) % len;
                tempArr[index] = a[i];
            }

            for (int i = 0; i < queries.Count; i++)
            {
                ans[i] = tempArr[queries[i]];
            }
            return ans;
        }
    }
}
