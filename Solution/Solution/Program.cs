using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.L3.L3._2;
namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.L3.L3._2.csharp.Solution s = new Solution.L3.L3._2.csharp.Solution();
            int[] a = {0,1, 2, 3,4, 5 };
          int b=  s.solution(a);
            Console.WriteLine(b+"");
            Console.ReadKey();
        }
       
        
    }
 }

