using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPrimerParcial.Clases;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROMOCIOM
            PasajeAereoPromoción promocion = new PasajeAereoPromoción();
            promocion.OrigenDelPasaje = "MONTECRISTE";
            promocion.Destino = "QUITO";
            promocion.DueñoDelPasaje = "Pablito";
            promocion.PrecioDePasaje = 300;
            promocion.DescuentoMitad = 50;

            //TURISTA
            PasajeAereoTurista turista = new PasajeAereoTurista();
            turista.OrigenDelPasaje = "MANTA";
            turista.Destino = "BRASIL";
            turista.DueñoDelPasaje = "Ubilla";
            turista.PrecioPasaje = 50;
            turista.Temporada = "Alta";
            
            //PREMIUM
            PasajeroAereoPremium premium = new PasajeroAereoPremium();
            premium.OrigenDelPasaje = "GUAYAQUIL";
            premium.Destino = "PERÚ";
            premium.DueñoDelPasaje = "Alex";
            premium.ValorFijo = 100;


            List<PasajerAereo> pasaje = new List<PasajerAereo>();
            pasaje.Add(promocion);
            pasaje.Add(turista);
            pasaje.Add(premium);

            foreach(PasajerAereo lista in pasaje)
            {
                Console.WriteLine(lista.imprimir() + "\n");
            }

            Console.ReadKey();

        }
    }
}
