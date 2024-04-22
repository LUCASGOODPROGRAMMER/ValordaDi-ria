using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDiária
{
    public static class Ferramentas
    {
        public static TimeSpan CalcularDiária(double valorDiaria, DateTime DataEntrada, DateTime DataSaida)
        {
            /*
            double valorHora = valorDiaria / 24;
            double valorMinuto = valorDiaria / 1440;
            double valorSegundo = valorDiaria / 86400;
            */
            if (DataSaida > DataEntrada)
            {
                TimeSpan Hora = DataSaida.Subtract(DataEntrada);
                
                return Hora;
            }
            else
            {
                TimeSpan Hora = DataEntrada.Subtract(DataSaida);
               
                return Hora;
            }
           


        }
    }
}
