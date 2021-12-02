namespace Out {
    class Calculator {

        /* o parâmetro Out não precisa que a
         variável seja iniciada, conforme o
        exemplo abaixo e no programa principal */
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
