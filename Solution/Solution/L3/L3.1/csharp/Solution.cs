using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.L3.L3._1.csharp
{
    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            int i = 0;
            if (X > Y || X == Y)
            {
                return i;
            }
            if ((D + X) > Y)
            {
                i = 1;
                return i;
            }
            else
            {
                int aux = Y - X;
                aux = aux / D;
                if (Y - X % D > 0)
                {
                    if ((aux * D) + X >= Y)
                    {
                        aux += 0;
                    }
                    else
                    {
                        aux += 1;
                    }
                }

                i = aux;
                return i;
            }
            
        }
    }
}