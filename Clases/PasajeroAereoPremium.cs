using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial.Clases
{
    public class PasajeroAereoPremium:PasajerAereo
    {
		private int valorfijo;

		public int ValorFijo
		{
			get { return valorfijo; }
			set { valorfijo = value; }
		}

		public override double precio()
		{
			return ((ValorFijo));
		}

		public override string imprimir()
		{
			return ("Origen del pasaje:" + OrigenDelPasaje + "\nDentino:" + Destino + "\nDueño del pasaje:" + DueñoDelPasaje+ "\nPrecio:" + precio());
		}
	}
}
