using System;
using HotelReservation.Entities;
using HotelReservation.Entities.Exceptions;

namespace HotelReservation {
    class Program {
        static void Main(string[] args) {

            // bloco que tentará rodar o programa abaixo
            try {
                // leitura do número do quarto, data de entrada e saída
                Console.Write("Room number: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (DD/MM/YYYY): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (DD/MM/YYYY): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                // instanciação da classe recebendo os dados acima
                Reservation reservation = new Reservation(num, checkIn, checkOut);

                // espaçamento e apresentação de dados
                Console.WriteLine();
                Console.Write("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine();

                // redigitação das datas para atualização da reserva
                Console.Write("Enter data to update the reservation: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (DD/MM/YYYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                // chamada do método que atualiza a reserva
                reservation.UpdateDates(checkIn, checkOut);

                // apresentação de dados
                Console.WriteLine();
                Console.Write("Reservation: " + reservation);
                // caso haja uma exceção, rodar conforme está na classe Reservation
            } catch (DomainException e) {
                Console.WriteLine("Error in reservation {0}", e.Message);
                // caso tenha sido digitado texto, mostrar o FormatException
            } catch (FormatException e) {
                Console.WriteLine("Format error: {0}", e.Message);
                // caso haja qualquer outro erro, mostrar que foi inesperado
            } catch (Exception e) {
                Console.WriteLine("Unexpected error: {0}", e.Message);
            }
        }
    }
}
