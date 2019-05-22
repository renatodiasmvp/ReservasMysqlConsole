using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaMysqlConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            CS_Reserva reserva = new CS_Reserva(0, DateTime.Parse("21/05/2019"), DateTime.Parse("25/05/2019"), 210.75);

            //reserva.Incluir();

            var dados = reserva.Listar(DateTime.Parse("21/05/2019"), DateTime.Parse("25/05/2019"), 210.75);

            while (dados.Read())
            {
                Console.WriteLine("ID: " + dados[3].ToString());
                Console.WriteLine("DATA_ENT: " + dados[0].ToString());
                Console.WriteLine("DATA_SAI: " + dados[1].ToString());
                Console.WriteLine("VALOR_TOTAL: " + dados[2].ToString());
            }

            Console.ReadLine();

        }
    }
}
