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
        private string selectedMember;
        
        public MemberController(MemberDALModel memberDAL, ListMembersView listMembersView)
        {
            this.memberDAL = memberDAL;
            this.listMembersView = listMembersView;

            this.selectedMember = this.listMembersView.GetMenuChoice();

            MemberView memberView = new MemberView(this.memberDAL, this.selectedMember);

            //MemberModel member = new MemberModel(name, socialSecurityNumber);

            //int memberId = (int)this.listMemberView.GetMenuChoice();
            //listMemberController.listChoice(this.showCompactList);

        }
    }
}
