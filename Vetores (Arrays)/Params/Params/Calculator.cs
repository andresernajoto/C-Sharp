namespace Params {
    class Calculator {

        public static int Sum(params int[] numbers) {
            int sum = 0;

            /* o params é um modificador de parâmetros,
             ele informa que a função abaixo vai receber
            uma quantia variável de valores */
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
