using System;
using System.Collections.Generic;

namespace GenericsExercice {
    class PrintServicee {

        // variáveis internas
        private int[] _values = new int[10];
        private int _count = 0;

        // operação que adiciona um valor à classe printService
        public void AddValue(int value) {
            if (_count == 10) {
                throw new InvalidOperationException("PrintService is full");
            }
            
            _values[_count] = value;
            _count++;
        }

        // retorna o primeiro valor que foi informado
        public int First() {
            if (_count == 0) {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        // função que imprime os valores de maneira formatada
        public void Print() {
            Console.Write("[ ");
            
            for (int i = 0; i < _count - 1; i++) {
                Console.Write(_values[i] + ", ");
            }

            if (_count > 0) {
                Console.Write(_values[_count - 1]);
            }
            Console.Write(" ]");
        }
    }
}
