using System;

namespace SetExercise.Entities {
    class LogRecord {

        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string username, DateTime instant) {
            Username = username;
            Instant = instant;
        }

        // adquire o HashCode de Username
        public override int GetHashCode() {
            return Username.GetHashCode();
        }

        // verifica se há nomes iguais
        public override bool Equals(object obj) {
            if (!(obj is LogRecord)) {
                return false;
            }

            // downcasting e retorno igualitário dos dados
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }
    }
}
