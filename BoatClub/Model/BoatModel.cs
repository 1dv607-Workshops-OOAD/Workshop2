using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class BoatModel
    {
        //private int boatId;
        //private string memberId;
        private string boatLength;
        private string boatType;
        public enum BoatType
        {
            Sailboat,
            KayakOrCanoe,
            Motorsailer,
            Other,
            None
        }

        public BoatModel(string boatType, string boatLength)
        {
            //this.memberId = memberId;
            this.boatLength = boatLength;
            this.boatType = boatType;
        }

        public BoatType getBoatType()
        {
            if (this.boatType == "1")
            {
                return BoatType.Sailboat;
            }
            if (this.boatType == "2")
            {
                return BoatType.KayakOrCanoe;
            }
            if (this.boatType == "3")
            {
                return BoatType.Motorsailer;
            }
            if (this.boatType == "4")
            {
                return BoatType.Other;
            }
            return BoatType.None;
        }

        public string getBoatLength()
        {
            return this.boatLength;
        }
    }
}