using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class StartController
    {
        private StartView startView;

        public void showSelectedMenu()
        {

            //view.Console.Event e;

            StartView.MenuChoice menuChoice = this.startView.GetMenuChoice();
            if (menuChoice == StartView.MenuChoice.AddMember)
            {
                AddMemberView addMemberView = new AddMemberView();
                addMemberView.showAddMemberView();
                //this.startView.showAddMemberView();
            }
            if (menuChoice == StartView.MenuChoice.ListMembers)
            {
                ListMemberView listMemberView = new ListMemberView();

            }
        }

        public StartController(StartView startView)
        {
            this.startView = startView;
        }
    }
}
