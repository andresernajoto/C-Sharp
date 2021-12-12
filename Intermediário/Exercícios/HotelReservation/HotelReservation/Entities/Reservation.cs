using System;
using HotelReservation.Entities.Exceptions;

namespace HotelReservation.Entities {
    class Reservation {
        
        // declaração das propriedades da classe
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        // construtor padrão
        public Reservation() { }

        // construtor que tem os parâmetros número do quarto, data de entrada e saída
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
            // verifica se a saída é menor que a entrada
            if (checkOut <= checkIn) {
                // lança uma nova exceção da classe DomainException com a frase abaixo
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        // método que calcula a duração da reserva
        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut) {
            // variável que recebe o momento atual
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now) {
                // lança uma nova exceção da classe DomainException com a frase abaixo
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkOut <= checkIn) {
                // lança uma nova exceção da classe DomainException com a frase abaixo
                throw new DomainException("Check-out date must be after check-in date");
            }

            // atualiza as datas digitadas anteriormente
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        // override para impressão do textoy
        public override string ToString() {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
