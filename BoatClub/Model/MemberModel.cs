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
        //private int numberOfBoats;

        public MemberModel(string name, string socialSecurityNumber)
        {
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
            writeSomething();
        }

        public void writeSomething()
        {
            Console.Write(this.name + this.socialSecurityNumber);
        }

    }
}
