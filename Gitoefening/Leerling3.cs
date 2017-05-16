using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitoefening
{
    public class Leerling3
    {
        string naam;
        string achternaam;
        int leeftijd;

        //methode om bovenstaande data te krijgen afmaken
        public void GetData()
        {
            naam = "Fabian";
            achternaam = "vanGellekom";
            leeftijd = 20;

        }

        //methode dat bovenstaande data terug geeft als string
        public string PresentData()
        {
            return naam + achternaam + leeftijd;
        }
    }
}
