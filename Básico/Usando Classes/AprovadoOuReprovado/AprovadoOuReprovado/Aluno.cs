using System;
using System.Globalization;

namespace AprovadoOuReprovado {
    class Aluno {

        // Declaração dos Atributos
        public string Nome;
        public double Nota1, Nota2, Nota3;

        // Soma das notas da pessoa
        public double SomaNotas() {
            return Nota1 + Nota2 + Nota3;
        }

        /* Condição para saber se o
        aluno é aprovado ou não */
        public bool Aprovacao() {
            if (SomaNotas() >= 60) {
                return true;
            } else {
                return false;
            }
        }

        /* Condição que calcula a 
         nota restante do aluno e
        mostra quantos pontos
        faltaram para alcançar a
        média */
        public double NotaRestante() {
            if (Aprovacao()) {
                return 0.0;
            } else {
                return 60 - SomaNotas();
            }
        }
    }
}
