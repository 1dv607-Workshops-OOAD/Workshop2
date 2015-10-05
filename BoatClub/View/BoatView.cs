using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class BoatView
    {
        private string boatType;
        private string boatLength;
        private MemberDALModel memberDAL;
        private string selectedMember;

        public enum MenuChoice
        {
            AddBoat,
            EditBoat,
            DeleteBoat,
            StartMenu,
            None
        }

        public BoatView(string selectedMember)
        {
            this.memberDAL = new MemberDALModel();
            this.selectedMember = selectedMember;
            Console.WriteLine("BoatView konstruktor " + selectedMember);
            showBoatMenu();
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

        public void showBoatMenu()
        {
            Console.Clear();
            Console.WriteLine("Ange 1 för att lägg till en båt.");
            Console.WriteLine("Ange 2 för att redigera båt.");
            Console.WriteLine("Ange 3 för att ta bort båt.");
            Console.WriteLine("Ange 4 för att gå tillbaka till startmenyn.");
        }

        public MenuChoice GetMenuChoice()
        {
            char menuChoice = System.Console.ReadKey().KeyChar;
            if (menuChoice == '1')
            {
                return MenuChoice.AddBoat;
            }
            if (menuChoice == '2')
            {
                return MenuChoice.EditBoat;
            }
            if (menuChoice == '3')
            {
                return MenuChoice.DeleteBoat;
            }
            if (menuChoice == '4')
            {
                return MenuChoice.StartMenu;
            }

            return MenuChoice.None;
        }

        public void listMemberBoats()
        {
            int counter = 0;

            Console.WriteLine("Testar " + this.selectedMember);
            Console.WriteLine("Båtar:");
            foreach (KeyValuePair<string, string> member in this.memberDAL.getMembersList())
            {
                if (member.Key == this.memberDAL.getMemberIdKey())
                {
                    counter = int.Parse(member.Value);
                }
                if (counter == int.Parse(this.selectedMember))
                {
                    if (member.Key == this.memberDAL.getBoatTypeKey() || member.Key == this.memberDAL.getBoatLengthKey())
                    {
                        Console.WriteLine("{0}: {1}", member.Key, member.Value);
                    }
                }
            }
        }

        //public void saveBoat()
        //{
        //    BoatModel boat = new BoatModel(boatView.getBoatType(), boatView.getBoatLength());
        //    this.memberDAL.saveBoat(this.selectedMember, boat);
        //    //this.memberView.showMember();
        //}

        //public void editBoat()
        //{

        //}

        //public void deleteBoat()
        //{

        //}
    }
}
