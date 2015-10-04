using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class AddMemberView
    {
        private string name;
        private string socialSecurityNumber;

        public AddMemberView()
        {
            //showAddMemberView();
        }

        public void showAddMemberView()
        {
            Console.Clear();
            Console.WriteLine("Lägg till medlem");

            Console.Write("Ange namn: ");
            this.name = Console.ReadLine();
            Console.Write("Ange personnummer: ");
            this.socialSecurityNumber = Console.ReadLine();
        }

        public string getName()
        {
            return this.name;
        }

        public string getSocialSecurityNumber()
        {
            return this.socialSecurityNumber;
        }
    }
}
