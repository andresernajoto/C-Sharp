namespace Ref {
    class Calculator {

        /* o parâmetro Ref serve como
         referência para o valor da
        variável no programa principal */
        public static void Triple(ref int x) {
            x = x * 3;
        }
    }
}
