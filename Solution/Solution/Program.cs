using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] teste = { 11, 12, 3, 2, 2, 2, 3, 12, 8, 1, 6, 8, 2, 1, 5, 14, 13, 14, 6, 3, 6, 7, 13, 10, 3, 4, 3, 12, 8, 9, 5, 7, 6, 5, 1, 12, 1, 5, 12, 13, 13, 7, 3, 14, 10, 14, 3, 7, 10, 9, 11, 1, 3, 4, 1, 14, 8, 14, 8, 4, 7, 7, 13, 10, 11, 1, 6, 11, 12, 11, 3, 13, 11, 1, 3, 2, 11, 8,
                8, 10, 1, 5, 9, 1, 11, 12, 4, 4, 2, 6, 13, 4, 11, 7, 3, 3, 10, 4, 3, 14, 1, 8, 14, 9, 9, 9, 2 };
            Solution s = new Solution();
            var dict = s.ConvertArrayToDict(teste);
            foreach (var item in dict)
            {
                Console.WriteLine("Item=" + item.Key + "|  Quantidade=" + item.Value);
            }

            Console.WriteLine(s.solution(teste));
            Console.ReadKey();
        }
        class Solution
        {
            public int solution(int[] A)
            {
                var numbers = ConvertArrayToDict(A);
                int result = GetOddOccurrences(numbers);



                return result;
            }

            public int GetOddOccurrences(Dictionary<int, long> numbers)
            {
                //1,3 -- 
                /*
                 <9,2>
                 <3,1>
                 <7,5>
                 
                 */

                long? min = null;
                int? aux = null;
                foreach (var item in numbers)
                {
                    if (min == null)
                    {
                        min = item.Value;
                        aux = item.Key;
                    }
                    else if (item.Value < min)
                    {
                        min = item.Value;
                        aux = item.Key;
                    }

                }
                min = !min.HasValue ? 0 : min;
                aux = !aux.HasValue ? 0 : aux;

                return aux.Value;
            }
            public Dictionary<int, long> ConvertArrayToDict(int[] A)
            {
                Dictionary<int, long> lista = new Dictionary<int, long>();
                foreach (var item in A)
                {
                    if (lista.ContainsKey(item))
                    {
                        lista[item]++;

                    }
                    else
                    {
                        lista.Add(item, 1);
                    }

                }

                return lista;

            }
        }

    }
}
