namespace CalculoDoRaio_V2._0 {
    class Calculadora {

        // atributo com o valor de PI
        public static double Pi = 3.14;

        /* método estático que calcula
        a circunferência de um raio*/
        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        /* método estático que calcula 
         o volume de um determinado raio*/
        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
