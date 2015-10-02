using BoatClub.Model;
using BoatClub.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class StartMenuController
    {
        private StartMenuView startView;
        private bool showCompactList = false;
        private MemberDALModel memberDAL;

        public void showSelectedMenu()
        {

            //SKAPA ETT MEMBERDAL-OBJEKT OCH SKICKA MED TILL ALLA CONTROLLERS
            this.memberDAL = new MemberDALModel();
            ListMemberController listMemberController = new ListMemberController(memberDAL);
            ListMemberView listMemberView = new ListMemberView();   

            StartMenuView.MenuChoice menuChoice = this.startView.GetMenuChoice();
            if (menuChoice == StartMenuView.MenuChoice.AddMember)
            {
                AddMemberView addMemberView = new AddMemberView();
                addMemberView.showAddMemberView();
                AddMemberController addMemberController = new AddMemberController(addMemberView, memberDAL);
                //this.startView.showAddMemberView();
            }
            if (menuChoice == StartMenuView.MenuChoice.CompactListMembers)
            {
                this.showCompactList = true;
                listMemberController.listChoice(this.showCompactList);
                this.memberDAL.setMemberList();
                //var getMemberList = this.memberDAL.getMemberList();
                /*foreach (KeyValuePair member in this.memberDAL.setMemberList()){
                    Console.WriteLine(member);
                }*/
                foreach( KeyValuePair<string, string> member in this.memberDAL.getMembersList() )
                {
                    Console.WriteLine("Key = {0}, Value = {1}", 
                        member.Key, member.Value);
                }
                
            }

            if (menuChoice == StartMenuView.MenuChoice.VerboseListMembers)
            {
                listMemberController.listChoice(this.showCompactList);
                //show verbose list
            }
        }

        public StartMenuController(StartMenuView startView)
        {
            this.startView = startView;
        }
    }
}
