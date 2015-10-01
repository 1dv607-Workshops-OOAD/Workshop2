using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class ListMemberController
    {
        private MemberDALModel memberDAL;

        //skapa och kalla på views
        public ListMemberController(MemberDALModel memberDAL)
        {
            this.memberDAL = memberDAL;            
        }

        public void listChoice(bool showCompactList)
        {
            ListMemberView listMemberView = new ListMemberView();

            if (showCompactList)
            {
                listMemberView.showCompactList();
            }
            else
            {
                listMemberView.showVerboseList();
            }
        }

    }
}
