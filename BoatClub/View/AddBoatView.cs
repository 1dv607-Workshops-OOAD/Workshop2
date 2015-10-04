using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class AddBoatView
    {
        private string boatType;
        private string boatLength;

        public AddBoatView()
        {
            addBoat();
        }

        public void addBoat()
        {
            Console.Clear();
            Console.WriteLine("Lägg till båt.");

            Console.WriteLine("Ange båttyp.\n1 för segelbåt.\n2 för kayak eller kanot.\n"
                + "3 för motorseglare.\n4 för annan typ. ");
            this.boatType = Console.ReadLine();
            Console.Write("Ange båtens längd: ");
            this.boatLength = Console.ReadLine();

            Console.WriteLine(this.boatType + " " + this.boatLength);
        }

        public string getBoatType()
        {
            return this.boatType;
        }

        public string getBoatLength()
        {
            return this.boatLength;
        }
    }
}
