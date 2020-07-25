using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial.Clases
{
    public class PasajeAereoPromoción:PasajerAereo
    {
        private int preciodepasaje;

        public int PrecioDePasaje
        {
            get { return preciodepasaje; }
            set { preciodepasaje = value; }
        }

        private int descuentomitad;

        public int DescuentoMitad
        {
            get { return descuentomitad; }
            set { descuentomitad = value; }
        }

        public override double precio()
        {
            return ((PrecioDePasaje * DescuentoMitad)/100);
        }
        public override string imprimir()
        {
            return ("Origen del Pasaje:"+OrigenDelPasaje + "\nDestino:"+ Destino+ "\nDueño del Pasaje:"+DueñoDelPasaje+ "\nPrecio del Pasaje:"+PrecioDePasaje+"\nDescuento del 50%:"+ DescuentoMitad+ "\nPrecio:"+precio());
        }
    }
}
