using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        // ATTRIBUTI
        public int baseRettangolo;
        public int altezzaRettangolo;

        //COSTRUTTORI
        public Rettangolo(int baseRettangolo, int altezzaRezzangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        // METODI
        public int calcolareArea()
        {
            int risultato = baseRettangolo * altezzaRettangolo;
            return risultato;
        }
         public int calcolarePerimetro()
        {
            int risultato = (baseRettangolo + altezzaRettangolo) * 2;
            return risultato;
        }



    }
}
