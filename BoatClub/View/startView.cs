using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class StartView
    {
        public enum MenuChoice {
            AddMember,
            ListMembers,
            None
        }

        public void showStartMenu()
        {
            Console.WriteLine("Välkommen till båtklubben!");
            Console.WriteLine("Välj nedan vad du vill göra.");
            Console.WriteLine("Tryck 1 för att lägga till medlem.");
            Console.WriteLine("Tryck 2 för att visa medlemslista");

            //Handle new member

            //Handle boat
        }

        public MenuChoice GetMenuChoice()
        {
            char c = System.Console.ReadKey().KeyChar;
            if (c == 1)
            {
                return MenuChoice.AddMember;
            }
            if (c == 2)
            {
                return MenuChoice.ListMembers;
            }

            return MenuChoice.None;
        }

        public StartView()
        {
            
        }
        
    }
}
