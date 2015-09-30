using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class StartMenuController
    {
        private StartMenuView startView;

        public void showSelectedMenu()
        {

            //SKAPA ETT MEMBERDAL-OBJEKT OCH SKICKA MED TILL ALLA CONTROLLERS

            StartMenuView.MenuChoice menuChoice = this.startView.GetMenuChoice();
            if (menuChoice == StartMenuView.MenuChoice.AddMember)
            {
                AddMemberView addMemberView = new AddMemberView();
                addMemberView.showAddMemberView();
                AddMemberController addMemberController = new AddMemberController(addMemberView);
                //this.startView.showAddMemberView();
            }
            if (menuChoice == StartMenuView.MenuChoice.CompactListMembers)
            {
                ListMemberView listMemberView = new ListMemberView();
                //show compact list
            }

            if (menuChoice == StartMenuView.MenuChoice.VerboseListMembers)
            {
                ListMemberView listMemberView = new ListMemberView();
                //show verbose list
            }
        }

        public StartMenuController(StartMenuView startView)
        {
            this.startView = startView;
        }
    }
}
