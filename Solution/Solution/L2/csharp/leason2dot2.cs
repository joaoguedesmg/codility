using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class leason2dot2
    {
        
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

