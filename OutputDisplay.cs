using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static GuestRelationData.GRM;

namespace GuestRelationData
{
    class OutputDisplay
    {
        public static void PrintData(GuestInfo G)
        {
            Console.WriteLine("Status: " + G.Status);
            Console.WriteLine("Name: " + G.Name);
            Console.WriteLine("Company: " + G.Company);
            Console.WriteLine("Favourite Room: " + G.FavouriteRoom);
            Console.WriteLine("Kids? : " + G.Kids);
            Console.WriteLine("Number of guests: " + G.Pax);
        }

        public static void WriteCharacters(GuestInfo G)
        {
            TextWriter writer = File.AppendText(@"C:\Users\msi\Documents\hotelguestinformation.txt");


            writer.WriteLine("Status: " + G.Status);
            writer.WriteLine("Name: " + G.Name);
            writer.WriteLine("Company: " + G.Company);
            writer.WriteLine("Favourite Room: " + G.FavouriteRoom);
            writer.WriteLine("Kids? : " + G.Kids);
            writer.WriteLine("Number of guests: " + G.Pax);
            writer.Close();
        }
    }
}
