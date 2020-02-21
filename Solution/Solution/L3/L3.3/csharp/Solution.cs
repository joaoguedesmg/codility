using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.L3.L3._3.csharp
{
    class Solution
    {
        public int solution(int[] A)
        {
            int sum = 0;
            int? min = null;
            foreach (int itens in A)
            {
                sum += itens;
            }
            int aux = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {

                aux += A[i];

                int temp = sum - aux;

                if (min == null || min > Math.Abs(temp - aux))
                {


                    min = Math.Abs(temp - aux);

                }



            }
            int result = min == null ? 0 : min.Value;
            return result;
        }
    }
}
