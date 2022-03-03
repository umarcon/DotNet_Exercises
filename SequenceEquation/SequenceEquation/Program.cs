using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SequenceEquation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

            List<int> p = new List<int>();

            p.Add(2);
            p.Add(3);
            p.Add(1);

            List<int> result = Result.permutationEquation(p);

            //textWriter.WriteLine(String.Join("\n", result));
            //
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
