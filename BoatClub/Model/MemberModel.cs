using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class MemberModel
    {
        private string socialSecurityNumber;
        private string name;
        private int memberId;
        //private MemberIDModel memberIdModel;
        //private int numberOfBoats;

        public MemberModel(string name, string socialSecurityNumber)
        {
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
            MemberIDModel memberIdModel = new MemberIDModel();
            memberId = memberIdModel.generateMemberId();
            writeSomething();
        }

        public void writeSomething()
        {
            Console.Write(this.name + this.socialSecurityNumber);
        }

    }
}
