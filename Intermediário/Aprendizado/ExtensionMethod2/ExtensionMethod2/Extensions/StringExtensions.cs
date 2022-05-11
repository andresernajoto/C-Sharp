namespace System {
    static class StringExtensions {

        public static string Cut(this string thisObj, int count) {
            // retornará a string cortada se passar do tamanho de count
            if (thisObj.Length <= count) {
                return thisObj;
            } else {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
