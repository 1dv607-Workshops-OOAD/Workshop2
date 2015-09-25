using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class Member
    {
        private int socialSecurityNumber;
        private string name;
        private int memberId = 1;
        //private int numberOfBoats;

        public Member(int socialSecurityNumber, string name)
        {
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
            
        }

    }
}
