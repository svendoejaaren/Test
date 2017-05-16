using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitoefening
{
    class Program
    {
        static void Main(string[] args)
        {
            Leerling1 leerling1 = new Leerling1();
            Leerling2 leerling2 = new Leerling2();
            Leerling3 leerling3 = new Leerling3();

            leerling1.GetData();
            //Console.WriteLine(leerling1.PresentData()); 

            leerling2.GetData();
            Console.WriteLine(leerling2.PresentData());

            //leerling3.GetData();
            //Console.WriteLine(leerling3.PresentData());

            Console.ReadKey();
        }
    }
}
