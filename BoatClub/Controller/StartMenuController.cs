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
        private MemberDALModel memberDAL;

        public StartMenuController()
        {
            this.startView = new StartMenuView();
            Console.Clear();
            this.startView.showStartMenu();
            showSelectedMenu();
        }

        public void showSelectedMenu()
        {
            this.memberDAL = new MemberDALModel();
            ListMembersView listMembersView = new ListMembersView();
                  

            StartMenuView.MenuChoice menuChoice = this.startView.GetMenuChoice();
            if (menuChoice == StartMenuView.MenuChoice.AddMember)
            {
                AddMemberView addMemberView = new AddMemberView();
                addMemberView.showAddMemberView();
                AddMemberController addMemberController = new AddMemberController(addMemberView, memberDAL);
            }
            else if (menuChoice == StartMenuView.MenuChoice.CompactListMembers ||
                menuChoice == StartMenuView.MenuChoice.VerboseListMembers)
            {
                if (menuChoice == StartMenuView.MenuChoice.CompactListMembers)
                {
                    listMembersView.showCompactList();
                }
                else
                {
                    listMembersView.showVerboseList();
                }
                MemberController listMemberController = new MemberController(listMembersView);
            }
            
        }
    }
}
