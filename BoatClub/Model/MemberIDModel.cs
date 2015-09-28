using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class MemberIDModel
    {

        public int generateMemberId(){
            //Skapa textfil med räknare av antal tillagda medlemmar
            //instruction https://msdn.microsoft.com/en-us/library/8bh11f1k.aspx
            string path = "../../AppData/memberID.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null){
                    //count = 1 
                    Console.WriteLine(line);
                    //Fortsätt här Skriv till fil...
                }
            }
            return 1;

        }
        
    }
}
