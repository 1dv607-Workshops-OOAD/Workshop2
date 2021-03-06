﻿using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoatClub.Controller
{
    class ListMembersView
    {
        private MemberDALModel memberDAL;

        public ListMembersView()
        {
            this.memberDAL = new MemberDALModel();
        }

        public void showCompactList()
        {
            Console.Clear();
            Console.WriteLine("Förenklad medlemslista");
            Console.WriteLine("Ange medlemsnummer för att ändra eller ta bort en medlem."); 
            foreach (KeyValuePair<string, string> member in this.memberDAL.getMembersList())
            {
                if (member.Key == this.memberDAL.getMemberIdKey())
                {
                    Console.WriteLine();
                }
                Console.WriteLine("{0}: {1}",
                    member.Key, member.Value);            
            }
        }

        public void showVerboseList()
        {
            Console.Clear();
            Console.WriteLine("Utökad medlemslista");
            Console.WriteLine("Ange medlemsnummer för att redigera en medlem och hantera dess båt(ar).");
            foreach (KeyValuePair<string, string> member in this.memberDAL.getMembersList())
            {
                if (member.Key == this.memberDAL.getMemberIdKey())
                {
                    Console.WriteLine();
                }
                Console.WriteLine("{0}: {1}",
                    member.Key, member.Value);
            }
        }

        public string GetMenuChoice()
        {
            Console.Write("\nMedlemsnummer: ");
            string menuChoice = Console.ReadLine();

            return menuChoice;
        }
        
    }
}
