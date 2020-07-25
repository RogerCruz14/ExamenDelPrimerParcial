using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial.Clases
{
    public abstract class PasajerAereo
    {
        private String origendepasaje;
        
        public String OrigenDelPasaje
        {
            get { return origendepasaje; }
            set { origendepasaje = value; }
        }

        private String destino;

        public String Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        private String dueñodepasaje;

        public String DueñoDelPasaje
        {
            get { return dueñodepasaje; }
            set { dueñodepasaje = value; }
        }

        public abstract double precio();
        public abstract string imprimir();
    }
}
