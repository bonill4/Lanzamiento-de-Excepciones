using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce numero de mes");

            int numMes = Int32.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(NombreDelMes(numMes));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje de la excepción: {ex.Message}");
            }

            Console.WriteLine("Aqui continuari el resto del programa");
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    //Con la clausula "throw = lansar". Lansa una excepcion 
                    throw new ArgumentOutOfRangeException();
            }
        } 
    }
}
