using HotelCachorro.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class ReservaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        

        public static bool CadastrarReserva(Reserva r)
        {

            //var lol = ctx.Reservas.Where(x => x.DataSaida < r.DataEntrada || x.DataEntrada > r.DataSaida).Select(y => y.Quarto.IdQuarto);
            //return true;

            if (r.DataEntrada < r.DataSaida && r.DataEntrada>=DateTime.Now)
            {
                if (ctx.Reservas.Include("Quarto").Any(x => x.DataSaida >= r.DataEntrada && x.DataEntrada <= r.DataSaida 
                && x.Quarto.IdQuarto == r.Quarto.IdQuarto) == true)
                {
                    return false;
                }
                else
                {


                    ctx.Reservas.Add(r);
                    ctx.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }


            
            // if (r.DataEntrada < r.DataSaida)

            //var DatasDisponiveis = ctx.Reservas.Where(x => x.DataSaida < r.DataEntrada || x.DataEntrada > r.DataSaida).
            //Select(y=>y.Quarto.IdQuarto);



            //var availableRooms = db.Rooms.Where(m => m.Reservations.All(r => r.Departure <= model.Arrival || r.Arrival >= model.Departure)
            // var availableRooms = ctx.Quartos.Where(m => m.Reservations.All(r => r.Departure <= model.Arrival || r.Arrival >= model.Departure)
        }



        public static bool ExcluirReserva(Reserva r)
        {
            
            ItensDAO.ProdutosPorCliente(r);

            Console.WriteLine(r);
            if (r != null)
            {

               
                ctx.Reservas.Remove(r);
                ctx.SaveChanges();
                return true;

            }
            return false;
        }

        public static Reserva BuscarReservaPorId(int reserva)
        {
            return ctx.Reservas.FirstOrDefault(x => x.IdReserva == reserva);
        }

        public static bool AlterarReserva(Reserva r)
        {

            var reservaAtual = ctx.Reservas.Include("Quarto").Where(b => b.Quarto.IdQuarto == r.Quarto.IdQuarto).
            Select(b => r.DataEntrada < b.DataSaida && r.DataEntrada > b.DataEntrada).FirstOrDefault();

            //Console.WriteLine(reservaAtual);

            if (r.DataEntrada < r.DataSaida && r.DataEntrada >= DateTime.Now)
            {

               
                if (ctx.Reservas.Include("Quarto").Any(x => x.DataSaida >= r.DataEntrada && x.DataEntrada <= r.DataSaida
                && x.Quarto.IdQuarto == r.Quarto.IdQuarto && x.IdReserva != r.IdReserva) == true)
                {
                    Console.WriteLine(r.DataEntrada);
                    return false;
                }
                else
                {
                    ctx.Entry(r).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }

        }


        public static List<Reserva> ListarReservas() => ctx.Reservas.Include("Pet").Include("Quarto").ToList();

    }
}
