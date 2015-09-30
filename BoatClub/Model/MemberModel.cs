using System;
using System.Collections.Generic;
using System.IO;
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
        private string idPath = "../../AppData/memberID.txt";
        private int count;
        //private MemberIDModel memberIdModel;
        //private int numberOfBoats;

        public MemberModel(string name, string socialSecurityNumber)
        {
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
            MemberIDModel memberIdModel = new MemberIDModel();
            this.memberId = memberIdModel.generateMemberId();
        }

        public string getName()
        {
            return this.name;
        }

        public string getSocialSecurityNumber()
        {
            return this.socialSecurityNumber;
        }

        public int getMemberId()
        {
            return this.memberId;
        }
        

        //public int generateMemberId()
        //{
        //    using (StreamReader reader = new StreamReader(idPath))
        //    {
        //        string line = reader.ReadLine();
        //        if (new FileInfo(idPath).Length == 0)
        //        {
        //            this.count = 1;
        //        }
        //        else
        //        {
        //            this.count = int.Parse(line);
        //            this.count++;
        //        }

        //    }
        //    writeToFile();
        //    return this.count;
        //}

        //Save number of generated memberId's to file
        //public void writeToFile()
        //{
        //    using (StreamWriter write = new StreamWriter(idPath, false))
        //    {
        //        write.Write(this.count);
        //    }
        //}
    }
}
