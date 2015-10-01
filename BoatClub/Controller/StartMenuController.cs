using BoatClub.Model;
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
        private bool showCompactList = false;

        public void showSelectedMenu()
        {

            //SKAPA ETT MEMBERDAL-OBJEKT OCH SKICKA MED TILL ALLA CONTROLLERS
            MemberDALModel memberDAL = new MemberDALModel();
            ListMemberController listMemberController = new ListMemberController(memberDAL);

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
                //kalla på controllern
                //show compact list
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
