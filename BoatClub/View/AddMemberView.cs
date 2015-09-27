using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class AddMemberView
    {
        public void showAddMemberView()
        {
            Console.Clear();
            Console.WriteLine("Lägg till medlem");
            Console.Write("Ange namn: ");
            string name = Console.ReadLine();
            Console.Write("Ange personnummer: ");
            string socialSecurityNumber = Console.ReadLine();
            Console.Write("Ange medlemsnummer: ");
            string memberId = Console.ReadLine();
            //Returnera detta och skicka til controllern för att skapa ny medlem i model.
        }
        
        public AddMemberView()
        {
            //showAddMemberView();
        }
    }
}
