using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.L1.csharp
{
    class Solution
    {
        public int solution(int N)
        {
            int resultado = foundGap(N);
            return resultado;
        }
        public List<char> convertToDecimal(int N)
        {
            string auxiliar = "";
            int aux = N;
            while (aux >= 1)
            {
                auxiliar += Convert.ToString(aux % 2);
                aux = aux / 2;
            }
            char[] aux2 = auxiliar.ToCharArray();
            Array.Reverse(aux2);
            auxiliar = new string(aux2);
            List<char> resultado = auxiliar.OfType<char>().ToList();
            return resultado;
        }
        public int foundGap(int N)
        {
            List<char> a = convertToDecimal(N);
            int min = 0;
            int max = 0;
           
            for (int i = 0; i < a.Count; i++)
            {

                if (a[i] == '0')
                {
                    min += 1;
                }
                else if (a[i] == '1')
                {

                    if (min > max)
                    {
                        max = min;

                    }
                    min = 0;
                }

            }
            return max;
        }
    }
}
