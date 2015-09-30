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
        //1. Spara båtar och medlemmar i samma fil?
        //2. Ska vi spara båtar och medlemmar via controllern eller modellen?
        static void Main(string[] args)
        {
            //Register member
            StartMenuView startView = new StartMenuView();
            startView.showStartMenu();
            StartMenuController startController = new StartMenuController(startView);

            startController.showSelectedMenu();
        }
    }
}
