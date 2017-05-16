using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitoefening
{
    public class Leerling2
    {
        string straatnaam;
        string huisdier;
        int lengte;

        //methode om bovenstaande data te krijgen afmaken
        public void GetData()
        {
            straatnaam = "poof";
            huisdier = "Giraffe";
            lengte = 3;
        }

        public string PresentData() {

            return straatnaam + huisdier + lengte;
        }

    }
}
