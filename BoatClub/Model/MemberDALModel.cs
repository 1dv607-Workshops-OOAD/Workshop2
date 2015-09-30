using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class MemberDALModel
    {
        private string folderPath = "../../AppData/Members/";

        public void saveMember(MemberModel member)
        {
            using (StreamWriter write = File.CreateText(folderPath + member.getMemberId() + ".txt"))
            {
                write.WriteLine("[Namn]");
                write.WriteLine(member.getName());
                write.WriteLine("[Personnummer]");
                write.WriteLine(member.getSocialSecurityNumber());
            }

            //if (File.Exists(folderPath + member.getMemberId() + ".txt"))
            //{
            //    Console.WriteLine("filen finns");
            //}
        }
    }
}
