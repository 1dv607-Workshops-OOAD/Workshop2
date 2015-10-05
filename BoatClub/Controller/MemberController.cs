using BoatClub.Model;
using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class MemberController
    {
        private MemberDALModel memberDAL;
        private ListMembersView listMembersView;
        private MemberView memberView;
        private string selectedMember;
        private char menuChoice;
        
        public MemberController(ListMembersView listMembersView)
        {
            this.memberDAL = new MemberDALModel();
            this.listMembersView = listMembersView;

            this.selectedMember = this.listMembersView.GetMenuChoice();

            this.memberView = new MemberView(this.selectedMember);
            this.memberView.showMember();
            this.menuChoice = memberView.GetMenuChoice();
            editMember();
        }

        public void editMember()
        {
            if (this.menuChoice == 'R')
            {
                this.memberView.editMember();
            }
            if (this.menuChoice == 'T')
            {
                this.memberDAL.deleteMember(this.selectedMember);
            }
            if (this.menuChoice == 'H')
            {
                BoatController boatController = new BoatController(this.selectedMember, this.memberView);
            }
            if (this.menuChoice == 'S')
            {
                StartMenuController startController = new StartMenuController();
            }
        }
    }
}
