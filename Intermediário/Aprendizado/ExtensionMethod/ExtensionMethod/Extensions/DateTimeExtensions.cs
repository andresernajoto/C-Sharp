using System.Globalization;

namespace System {
    static class DateTimeExtensions {

        public static string ElapsedTime(this DateTime thisObj) {
            // subtrai o horário atual pelo passado como parâmetro
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            // retorna a duração em horas e dias, dependendo do caso
            if (duration.TotalHours < 24.0) {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            } else {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
