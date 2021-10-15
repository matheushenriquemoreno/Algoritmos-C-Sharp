using System;
using Exercicio_tratamento_excecoes.Entities.Exceptions;

namespace Exercicio_tratamento_excecoes.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

    
        public Reservation (int number, DateTime entrada, DateTime saida)
        {
            if (saida <= entrada)
            {
                throw new DomainException("Erro in reservarion: Check-out date must be check-in");
            }
            RoomNumber = number;
            CheckIn = entrada;
            CheckOut = saida;
        }


        public int Duration()
        {
            TimeSpan Duration = CheckOut.Subtract(CheckIn); // pega a diferença entre a saida e entrada
            return  (int)Duration.TotalDays;
        }
        
        public void UpdateDates(DateTime entrada, DateTime saida)
        {
          
            DateTime now = DateTime.Now;

            if (entrada < now && saida < now)
            {
                 throw new DomainException ("Error in reservation!");
            }
            if (saida <= entrada)
            {
               throw new DomainException ("Erro in reservarion: Check-out date must be check-in");
            }

            CheckIn = entrada;
            CheckOut = saida;

        }


        public override string ToString()
        {
            return $"Room {RoomNumber}, Check-in: {CheckIn.ToString("dd/MM/yyyy")}, Check-out {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} Nights";
        }
    }
}
