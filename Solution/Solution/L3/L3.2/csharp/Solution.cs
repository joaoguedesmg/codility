using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.L3.L3._2.csharp
{
    class Solution
    {
        public int solution(int[] A)
        {
            int maior = 0;
            int total = 0;
            int resultado;

            if (A.Length == 0)
            {
                return 1;
            }

            foreach(int itens in A)
            {
                total += itens;
                if (itens > maior)
                {
                    
                    maior = itens;
                    
                }
            }
            resultado = (maior * (maior + 1)) / 2;
            if (resultado <= total)
            {
                return maior + 1;
            }
           
            resultado -= total;
            
            return resultado;
        }
    }
    
}