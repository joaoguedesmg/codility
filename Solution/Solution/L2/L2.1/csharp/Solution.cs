using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.L2.L2._1.csharp
{
    class Solution
    {
        public int[] solution(int[] A, int k)
        {

            int[] aux = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                aux[(i + k) % A.Length] = A[i];
            }
            return aux;
        }
    }
}
