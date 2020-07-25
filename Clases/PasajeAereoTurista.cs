using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial.Clases
{
    public class PasajeAereoTurista:PasajerAereo
    {

        private double presiopasaje;

        public double PrecioPasaje
        {
            get { return presiopasaje; }
            set { presiopasaje = value; }
        }

       
        private String temporada;

        public String Temporada
        {
            get { return temporada; }
            set { temporada = value; }
        }
        public override double precio()
        {
            double total=PrecioPasaje;
            if (Temporada=="Alta")
            {
                total = PrecioPasaje * 1.30;
            }
            return total;
        }
        public override string imprimir()
        {
            return ("Origen del pasaje:"+OrigenDelPasaje+ "\nDentino:" + Destino+ "\nDueño del pasaje:" + DueñoDelPasaje+ "\nPrecio del pasaje:" + PrecioPasaje+ "\nTemporada:" + Temporada+ "\nPrecio:" + precio());
        }
    }
}