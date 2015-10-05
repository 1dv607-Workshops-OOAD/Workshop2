using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class BoatModel
    {
        private string boatLength;
        private string boatType;
        public enum BoatType
        {
            Segelbåt,
            Kajak,
            Motorseglare,
            Annan,
            None
        }

        public BoatModel(string boatType, string boatLength)
        {
            this.boatLength = boatLength;
            this.boatType = boatType;
        }

        public BoatType getBoatType()
        {
            if (this.boatType == "1")
            {
                return BoatType.Segelbåt;
            }
            if (this.boatType == "2")
            {
                return BoatType.Kajak;
            }
            if (this.boatType == "3")
            {
                return BoatType.Motorseglare;
            }
            if (this.boatType == "4")
            {
                return BoatType.Annan;
            }
            return BoatType.None;
        }

        public string getBoatLength()
        {
            return this.boatLength;
        }
    }
}