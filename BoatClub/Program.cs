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
        static void Main(string[] args)
        {
            //Register member
            StartView startView = new StartView();
            startView.showStartMenu();
            StartController startController = new StartController(startView);

            
        }
    }
}
