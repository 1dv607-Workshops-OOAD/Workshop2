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
        private const string SectionName = "[Namn]";
        private const string SectionSocialSecurityNumber = "[Personnummer]";

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
            DirectoryInfo di = new DirectoryInfo(folderPath);
            FileInfo[] fi = di.GetFiles();
            string line;
            //skapa variabler för alla keyvalues: id, namn, personnummer, båtar
            foreach (FileInfo file in fi)
            {
                string memberId = Path.GetFileNameWithoutExtension(this.folderPath + file);
           
                using (StreamReader read = new StreamReader(this.folderPath + file))
                {
                    while ((line = read.ReadLine()) != null)
                    {
                        //lägg till memberId / filnamn utan .txt i members[]
                        //lägg till namn
                        //lägg till personnummer
                        //lägg till medelemsinfo från fil till members[]
                    }
                }
                this.members.Add(new KeyValuePair<string, string>("Id", memberId));
            }  
        }

        public List<KeyValuePair<string, string>> getMembersList()
        {
            return this.members;
        }
    }
}
