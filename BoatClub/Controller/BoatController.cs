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
            showSelectedMenu();
            
           
        }

        public void showSelectedMenu()
        {
            Console.WriteLine("ShowSelectedMenu i BoatController");
            BoatView.MenuChoice menuChoice = this.boatView.GetMenuChoice();
            

            if (menuChoice == BoatView.MenuChoice.AddBoat)
            {
                Console.WriteLine("Add boat");
                this.boatView.addBoat();
                BoatModel boat = new BoatModel(boatView.getBoatType(), boatView.getBoatLength());
                this.memberDAL.saveBoat(this.selectedMember, boat);
                MemberView editedMemberView = new MemberView(this.selectedMember);
                editedMemberView.showMember();
            }
            if (menuChoice == BoatView.MenuChoice.EditBoat)
            {
                this.boatView.listMemberBoats();
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
        //public void showSelectedMenu()
        //{
        //    BoatView.MenuChoice menuChoice = this.boatView.GetMenuChoice();

        //    if (menuChoice == BoatView.MenuChoice.AddBoat)
        //    {
        //        this.boatView.addBoat();
        //        BoatModel boat = new BoatModel(boatView.getBoatType(), boatView.getBoatLength());
        //        this.memberDAL.saveBoat(this.selectedMember, boat);
        //        MemberView editedMemberView = new MemberView(this.selectedMember);
        //        editedMemberView.showMember();
        //    }
        //    if (menuChoice == BoatView.MenuChoice.EditBoat || menuChoice == BoatView.MenuChoice.DeleteBoat)
        //    {
        //        Console.WriteLine("Edit eller delete");
        //        this.boatView.listMemberBoats();
        //        string selectedBoat = "";

        //        if (menuChoice == BoatView.MenuChoice.DeleteBoat)
        //        {
        //            Console.WriteLine("Delete båt");
        //            selectedBoat = this.boatView.getEditMenuChoice();
        //            this.memberDAL.deleteBoat(selectedBoat);
        //        }
        //    }

        //    if (menuChoice == BoatView.MenuChoice.StartMenu)
        //    {
        //        StartMenuController startController = new StartMenuController();
        //    }


        //}
    }
}
