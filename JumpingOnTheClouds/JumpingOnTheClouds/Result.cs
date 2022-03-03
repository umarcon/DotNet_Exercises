using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    public class Result
    {
        public static int jumpingOnClouds(int[] c, int k)
        {
            int cloudCharge = 100;

            for (int i = 0; i < Convert.ToInt32(c[0].ToString()); i++)
            {
                int resto = i % k;
                if (i>0 && resto == 0)
                {
                    if (cloudCharge % k == 0)
                    {
                        cloudCharge = cloudCharge - (k + 1);
                    }
                    else
                    {
                        cloudCharge = cloudCharge - 1;
                    }
                }
                else
                {
                    if ((i + 1) == c[0])
                    {
                        cloudCharge = cloudCharge - 1;
                    }
                }
            }

            return cloudCharge;
        }
    }
}
