using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuestRelationData
{
    public class GRM
    {
        public enum GuestStatus
        {
            VIP,
            Government,
            Weekly,
            Monthly,
            Group,
            Event,
            Staff,
            Blacklist,
        };

        public struct GuestInfo
        {
            public GuestStatus Status;
            public string Name;
            public string Company;
            public int FavouriteRoom;
            public bool Kids;
            public int KidsNumber;
            public int Pax;
        }
        public static void Data()
        {
            const int CURRENT_GUESTS_DATA = 5;

            GuestInfo[] Hotel = new GuestInfo[CURRENT_GUESTS_DATA];
            Hotel[0].Name = "Antoine";
            Hotel[0].Status = GuestStatus.Staff;
            Hotel[0].Company = "Hilton";
            Hotel[0].FavouriteRoom = 88;
            Hotel[0].Pax = 2;
            Hotel[0].Kids = false;
            OutputDisplay.PrintData(Hotel[0]);
            OutputDisplay.WriteCharacters(Hotel[0]);
            Console.WriteLine("\n \n");

            Hotel[1].Name = "Steve";
            Hotel[1].Status = GuestStatus.Weekly;
            Hotel[1].FavouriteRoom = 110;
            OutputDisplay.PrintData(Hotel[1]);
            OutputDisplay.WriteCharacters(Hotel[1]);
            Console.WriteLine("\n \n");

            Hotel[2].Name = "Tian";
            Hotel[2].Status = GuestStatus.Event;
            Hotel[2].Company = "China Mobile";
            Hotel[2].Pax = 83;
            OutputDisplay.PrintData(Hotel[2]);
            OutputDisplay.WriteCharacters(Hotel[2]);
            Console.WriteLine("\n \n");
        }        
    }
}
