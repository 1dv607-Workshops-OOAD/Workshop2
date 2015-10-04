using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class StartMenuView
    {
        public enum MenuChoice {
            AddMember,
            CompactListMembers,
            VerboseListMembers,
            AddBoat,
            None
        }

        public void showStartMenu()
        {
            Console.WriteLine("Välkommen till båtklubben!");
            Console.WriteLine("Välj nedan vad du vill göra.");
            Console.WriteLine("Tryck 1 för att lägga till medlem.");
            Console.WriteLine("Tryck 2 för att visa medlemslista."); //med antal båtar
            Console.WriteLine("Tryck 3 för att visa utökad medlemslista."); //med båtinfo
            Console.WriteLine("Tryck 4 för att lägga till en båt.");
        }

        public MenuChoice GetMenuChoice()
        {
            char menuChoice = System.Console.ReadKey().KeyChar;
            if (menuChoice == '1')
            {
                return MenuChoice.AddMember;
            }
            if (menuChoice == '2')
            {
                return MenuChoice.CompactListMembers;
            }
            if (menuChoice == '3' || menuChoice == '4')
            {
                return MenuChoice.VerboseListMembers;
            }

            return MenuChoice.None;
        }

        public StartMenuView()
        {
            
        }
        
    }
}
