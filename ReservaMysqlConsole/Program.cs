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
            string dataEnt = "";
            string dataSai = "";
            string valorTotal = "";
            Console.WriteLine("Reservas");
            Console.WriteLine("=========================");
            Console.WriteLine("Digite a Data de Entrada:");
            dataEnt = Console.ReadLine();
            Console.WriteLine("Digite a Data de Saída:");
            dataSai = Console.ReadLine();
            Console.WriteLine("Digite o Valor Total:");
            valorTotal = Console.ReadLine();

            CS_Reserva reserva = new CS_Reserva(0, DateTime.Parse(dataEnt), DateTime.Parse(dataSai), Double.Parse(valorTotal));

            reserva.Incluir();

            var dados = reserva.Listar(DateTime.Parse(dataEnt), DateTime.Parse(dataSai), Double.Parse(valorTotal));

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
