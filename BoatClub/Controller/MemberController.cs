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
        
        public MemberController(MemberDALModel memberDAL, ListMembersView listMembersView)
        {
            this.memberDAL = memberDAL;
            this.listMembersView = listMembersView;

            this.selectedMember = this.listMembersView.GetMenuChoice();

            this.memberView = new MemberView(this.memberDAL, this.selectedMember);
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
                this.memberDAL.deleteMember(this.memberView.getSelectedMember());
            }
        }
    }
}
