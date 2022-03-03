using System;
using System.IO;

namespace JumpingOnTheClouds
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = new int[] { n, k };

            int result = Result.jumpingOnClouds(c, k);

            //textWriter.WriteLine(result);
            //
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
