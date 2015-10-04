using BoatClub.Model;
using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class AddMemberController
    {
        private AddMemberView addMemberView;
        
        public AddMemberController(AddMemberView addMemberView, MemberDALModel memberDAL)
        {
            this.addMemberView = addMemberView;
            MemberModel member = new MemberModel(addMemberView.getName(), addMemberView.getSocialSecurityNumber());
            memberDAL.saveMember(member);
            StartMenuController startMenu = new StartMenuController();
        }
    }
}
