﻿using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class MemberView
    {
        private MemberDALModel memberDAL;
        private string selectedMember;
        private List<KeyValuePair<string, string>> members = new List<KeyValuePair<string, string>>();
        private string name;
        private string socialSecurityNumber;

        public MemberView(MemberDALModel memberDAL, string selectedMember)
        {
            this.memberDAL = memberDAL;
            this.selectedMember = selectedMember;

            this.members = this.memberDAL.getMembersList();
            this.showMember();
        }
        public void showMember()
        {
            int counter = 0;

            Console.Clear();
           
            Console.WriteLine("Ange R för att redigera medlem.");
            Console.WriteLine("Ange T för att ta bort medlem.");
            Console.WriteLine("Ange B för att lägga till en båt.");

            Console.WriteLine("Vald medlem:");
            foreach (KeyValuePair<string, string> member in this.memberDAL.getMembersList())
            {
                if (member.Key == this.memberDAL.getMemberIdKey())
                {
                    counter = int.Parse(member.Value);
                }
                if (counter == int.Parse(this.selectedMember))
                {
                    Console.WriteLine("{0}: {1}", member.Key, member.Value);
                    if (member.Key == this.memberDAL.getNameKey()){
                        this.name = member.Value;
                    }
                    if (member.Key == this.memberDAL.getSocialSecurityNumberKey())
                    {
                        this.socialSecurityNumber = member.Value;
                    }
                }
            }
        }

        //FORTSÄTT HÄR - Radera eller redigera en medlem beroende på menyval
        public char GetMenuChoice()
        {
            char menuChoice = System.Console.ReadKey().KeyChar;

            return Char.ToUpper(menuChoice);
        }

        public string getSelectedMember()
        {
            return this.selectedMember;
        }

        public void editMember()
        {
            Console.WriteLine("\nFyll i de fält du vill redigera. \nTryck enter för att gå vidare till nästa fält. \nLämna tomt om du inte vill redigera det markerade fältet.");
            Console.Write("Namn: ");
            string name = Console.ReadLine();
            Console.Write("Personummer: ");
            string socialSecurityNumber = Console.ReadLine();
            if (name == "")
            {
                name = this.name;
            }
            if (socialSecurityNumber == "")
            {
                socialSecurityNumber = this.socialSecurityNumber;
            }
            //Console.WriteLine(name + " " + socialSecurityNumber);
            this.memberDAL.saveEditedMember(this.selectedMember, name, socialSecurityNumber);
        }
    }
}
