using System;
using System.Collections;
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
        private List<KeyValuePair<string, string>> members = new List<KeyValuePair<string, string>>();
        private string SectionName = "[Namn]";
        private string SectionSocialSecurityNumber = "[Personnummer]";

        private string memberIdKey = "Medlemsnummer";
        private string nameKey = "Namn";
        private string socialSecurityNumberKey = "Personnummer";

        private enum MemberReadStatus { Indefinite, New, Name, SocialSecurityNumber };

        public string getMemberIdKey()
        {
            return this.memberIdKey;
        }

        public FileInfo[] getFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            FileInfo[] files = directory.GetFiles();

            return files;
        }

        public void saveMember(MemberModel member)
        {
            using (StreamWriter write = File.CreateText(folderPath + member.getMemberId() + ".txt"))
            {
                write.WriteLine("[Namn]");
                write.WriteLine(member.getName());
                write.WriteLine("[Personnummer]");
                write.WriteLine(member.getSocialSecurityNumber());
                write.WriteLine("[Båtar]");
            }
        }

        public void setMemberList()
        {           
            string line;

            foreach (FileInfo file in this.getFiles())
            {
                string name = "";
                string socialSecurityNumber = "";
                string memberId = Path.GetFileNameWithoutExtension(this.folderPath + file);
           
                using (StreamReader read = new StreamReader(this.folderPath + file))
                {
                    while ((line = read.ReadLine()) != null)
                    {
                        //lägg till namn
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            if (line == SectionName)
                            {
                                name = read.ReadLine();
                            }
                            if (line == SectionSocialSecurityNumber)
                            {
                                socialSecurityNumber = read.ReadLine();
                            }
                        }
                    }
                }
                this.members.Add(new KeyValuePair<string, string>(this.memberIdKey, memberId));
                this.members.Add(new KeyValuePair<string, string>(this.nameKey, name));
                this.members.Add(new KeyValuePair<string, string>(this.socialSecurityNumberKey, socialSecurityNumber));
            }  
        }

        public List<KeyValuePair<string, string>> getMembersList()
        {
            return this.members;
        }

        //public string getMember(string memberId)
        //{
        //    string name = "";
        //    string socialSecurityNumber = "";
        //    string line;

        //    foreach (FileInfo file in this.getFiles())
        //    {
        //        if (Path.GetFileNameWithoutExtension(this.folderPath + file) == memberId)
        //        {
        //            using (StreamReader read = new StreamReader(this.folderPath + file))
        //            {
        //                while ((line = read.ReadLine()) != null)
        //                {
        //                    //lägg till namn
        //                    if (!string.IsNullOrWhiteSpace(line))
        //                    {
        //                        if (line == SectionName)
        //                        {
        //                            name = read.ReadLine();
        //                        }
        //                        if (line == SectionSocialSecurityNumber)
        //                        {
        //                            socialSecurityNumber = read.ReadLine();
        //                        }
        //                    }
        //                }
        //            }
        //            //MemberModel member = new MemberModel();
        //            return "Hej";
        //        }
        //        return "Hopp";
        //    }
        //    return "hå";
        //}
    }
}
