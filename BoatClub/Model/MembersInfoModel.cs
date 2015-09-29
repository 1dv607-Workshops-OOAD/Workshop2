using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class MembersInfoModel
    {
        private MemberModel member;
        private string path = "../../AppData/members.txt";

        public MembersInfoModel(MemberModel member)
        {
            this.member = member;
        }

        public void saveMember()
        {
            using (StreamWriter write = new StreamWriter(path))
            {
                write.WriteLine(this.member.getName());
                write.WriteLine(this.member.getMemberId());
            }
        }
    }
}
