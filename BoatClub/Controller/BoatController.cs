using BoatClub.Model;
using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class BoatController
    {
        private MemberDALModel memberDAL;
        private BoatView boatView;
        private MemberView memberView;
        private string selectedMember;

        public BoatController(string selectedMember, MemberView memberView)
        {
            this.selectedMember = selectedMember;
            this.boatView = new BoatView(this.selectedMember);
            this.memberDAL = new MemberDALModel();
            this.memberView = memberView;
            Console.WriteLine("Vald medlems id-nummer" + this.selectedMember);
            showSelectedMenu();
            
           
        }

        public void showSelectedMenu()
        {
            BoatView.MenuChoice menuChoice = this.boatView.GetMenuChoice();

            if (menuChoice == BoatView.MenuChoice.AddBoat)
            {
                this.boatView.addBoat();
                BoatModel boat = new BoatModel(boatView.getBoatType(), boatView.getBoatLength());
                this.memberDAL.saveBoat(this.selectedMember, boat);
                MemberView editedMemberView = new MemberView(this.selectedMember);
                editedMemberView.showMember();
            }
            if (menuChoice == BoatView.MenuChoice.EditBoat)
            {
                
            }
            if (menuChoice == BoatView.MenuChoice.DeleteBoat)
            {
                this.boatView.listMemberBoats();
            }
            if (menuChoice == BoatView.MenuChoice.StartMenu)
            {
                StartMenuController startController = new StartMenuController();
            }


        }
    }
}
