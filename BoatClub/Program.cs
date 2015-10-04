using BoatClub.Controller;
using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub
{
    class Program
    {
        //Frågor:
        //1. Spara båtar och medlemmar i samma fil? Ja. XML, samma fil.
        //2. Ska vi spara båtar och medlemmar via controllern eller modellen?
        //   klass som representerar ett medlemsregister med load, save och delete members
        //Ladda in databasen, gör ändringar i programmet när vi kör. Spara ner innan avslut.
        //Skillnad mot webben.
        static void Main(string[] args)
        {
            StartMenuController startController = new StartMenuController();
        }
    }
}
