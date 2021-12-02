namespace CotacaoDolar {
    class ConversorDeMoeda {

        // decalração de atributo estático
        public static double Iof = 0.06;

        /* declaração do método estático que
         calcula a conversão de dólar em real,
        considerando o valor do IoF*/
        public static double CalculoConversor(double cD, double dC) {
            return (cD * dC) * Iof + (cD * dC);
        }
    }
}
