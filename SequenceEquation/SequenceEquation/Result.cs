using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEquation
{
    public class Result
    {
        /*
         * Complete the 'permutationEquation' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY p as parameter.
         */

        public static List<int> permutationEquation(List<int> p)
        {
            List<int> result = new List<int>();
            List<int> resultFinal = new List<int>();

            for (int i = 1; i <= p.Count; i++)
            {
                if (Convert.ToInt32(p[i-1].ToString()) != i)
                {
                    for (int j = 1; j <= p.Count; j++)
                    {
                        if (Convert.ToInt32(p[j-1].ToString()) == i)
                        {
                            result.Add(j);
                        }
                    }
                }
                else
                {
                    result.Add(i);
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] != p[i])
                {
                    for (int j = 0; j < result.Count; j++)
                    {
                        if (result[i] == p[j])
                        {
                            resultFinal.Add(j + 1);
                            break;
                        }
                    }
                }
                else
                {
                    resultFinal.Add(i + 1);
                }
            }

            return resultFinal;
        }
    }
}
