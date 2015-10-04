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
        private string SectionBoats = "[Båtar]";

        private string memberIdKey = "Medlemsnummer";
        private string nameKey = "Namn";
        private string socialSecurityNumberKey = "Personnummer";
        private string boatTypeKey = "Båttyp";
        private string boatLengthKey = "Båtlängd";

        private enum MemberReadStatus { Indefinite, New, Name, SocialSecurityNumber };

        public string getMemberIdKey()
        {
            return this.memberIdKey;
        }

        public string getNameKey()
        {
            return this.nameKey;
        }

        public string getSocialSecurityNumberKey()
        {
            return this.socialSecurityNumberKey;
        }

        public FileInfo[] getFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            FileInfo[] files = directory.GetFiles();

            return files;
        }

        public void saveMember(MemberModel member)
        {
            using (StreamWriter write = File.CreateText(this.folderPath + member.getMemberId() + ".txt"))
            {
                write.WriteLine(this.SectionName);
                write.WriteLine(member.getName());
                write.WriteLine(this.SectionSocialSecurityNumber);
                write.WriteLine(member.getSocialSecurityNumber());
                write.WriteLine(this.SectionBoats);
            }
        }

        public void setMemberList()
        {           
            string line;
            
            foreach (FileInfo file in this.getFiles())
            {
                string name = "";
                string socialSecurityNumber = "";
                //string boatType = "";
                //string boatLength = "";
                List<String> boats = new List<String>();
                //List<KeyValuePair<string, string>> boats = new List<KeyValuePair<string, string>>();
                string memberId = Path.GetFileNameWithoutExtension(this.folderPath + file);
           
                using (StreamReader read = new StreamReader(this.folderPath + file))
                {
                    int lineCount = 0;
                    while ((line = read.ReadLine()) != null)
                    {
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
                            if (line == SectionBoats)
                                //if (line == SectionBoats || (line != SectionName && line != SectionSocialSecurityNumber))
                            {
                                //read.ReadLine();
                                for (int i = 0; i < (file.Length - lineCount); i++)
                                {
                                    //if ((line = read.ReadLine()) != null)
                                    if (line != null)
                                    {
                                        boats.Add(read.ReadLine());
                                        lineCount++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                    
                                //continue;

                                //string nextLine = read.ReadLine();
                                //Console.WriteLine("section boats");
                                ////Console.WriteLine(nextLine);
                                ////do
                                ////{

                                //    boatType = read.ReadLine();
                                //    //this.members.Add(new KeyValuePair<string, string>(this.boatTypeKey, boatType));
                                //    boatLength = read.ReadLine();
                                //    //this.members.Add(new KeyValuePair<string, string>(this.boatLengthKey, boatLength));

                                //    //boats.Add(new KeyValuePair<string, string>(this.boatTypeKey, boatType));
                                //    //boats.Add(new KeyValuePair<string, string>(this.boatLengthKey, boatLength));
                                //    boats.Add(boatType);
                                //    boats.Add(boatLength);
                                //    //Console.WriteLine(boats.ToString());

                                ////} while (nextLine != null);
                            }
                            //else
                            //{
                            //boats.Add(read.ReadLine());
                            //}
                            lineCount++;
                        }
                        
                    }
                }
                this.members.Add(new KeyValuePair<string, string>(this.memberIdKey, memberId));
                this.members.Add(new KeyValuePair<string, string>(this.nameKey, name));
                this.members.Add(new KeyValuePair<string, string>(this.socialSecurityNumberKey, socialSecurityNumber));

                Console.WriteLine("test1");


                for (int i = 0; i < boats.Count; i++)
                {
                    Console.WriteLine("test2");
                    if((i+1) % 2 != 0)
                    {
                        this.members.Add(new KeyValuePair<string, string>(this.boatTypeKey, boats[i]));
                        Console.WriteLine("Jämn");
                    }
                    else
                    {
                        this.members.Add(new KeyValuePair<string, string>(this.boatLengthKey, boats[i]));
                        Console.WriteLine("Ojämn");
                    }
                }
                boats = null;
            }  
        }

        public List<KeyValuePair<string, string>> getMembersList()
        {
            return this.members;
        }

        public void saveEditedMember(string memberId, string name, string socialSecurityNumber)
        {
            using (StreamWriter write = File.CreateText(this.folderPath + memberId + ".txt"))
            {
                write.WriteLine(this.SectionName);
                write.WriteLine(name);
                write.WriteLine(this.SectionSocialSecurityNumber);
                write.WriteLine(socialSecurityNumber);
                write.WriteLine(this.SectionBoats);
            }
        }

        public void deleteMember(string memberId)
        {
            File.Delete(this.folderPath + memberId + ".txt");
        }

        public void saveBoat(string memberId, BoatModel boat)
        {
            using (StreamWriter write = File.AppendText(this.folderPath + memberId + ".txt"))
            {
                write.WriteLine(boat.getBoatType().ToString());
                write.WriteLine(boat.getBoatLength());
            }
        }
    }
}
