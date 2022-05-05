using System;
using System.Collections.Generic;

namespace GenericsRestriction.Services {
    class CalculationService {
        // operação genérica que faz com que ela possa ser comparada
        public T Max<T>(List<T> list) where T : IComparable {
            // lançamento de exceção caso a list seja vazia
            if (list.Count == 0) {
                throw new ArgumentException("The list can't be empty");
            }

            // recebe o primeiro elemento da lista
            T max = list[0];
            
            // faz a comparação para identificar o valor máximo
            for (int i = 0; i < list.Count; i++) {
                // comparação entre os tipos genéricos por meio da interface IComparable
                if (list[i].CompareTo(max) > 0) {
                    max = list[i];
                }
            }

             // retorna o valor na operação
            return max;
        }
    }
}
