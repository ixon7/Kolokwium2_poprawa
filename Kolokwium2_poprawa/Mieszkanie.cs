using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kolokwium2_poprawa
{
    public class Mieszkanie
    {
        public int Metraz { get; set; }
        public string Nazwa { get; set; }
        public int OdlegloscOdCentrum { get; set; }

        public Mieszkanie(int metraz, string nazwa, int odlegloscodcentrum)
        {
            Metraz = metraz;
            Nazwa = nazwa;
            OdlegloscOdCentrum = odlegloscodcentrum;
        }
       
    }
}
