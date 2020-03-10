using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StaffMember> allMembers = new List<StaffMember>{ new Scholar(), new Junior(), new Senior(), new Manager()};
            foreach(StaffMember currentMember in allMembers)
            {
                Console.WriteLine("Member of type " + currentMember.GetName() + " has access to:");
                showAccess(currentMember.GetAccess(new StaffVisitorAccess()));
            }
            Console.ReadLine();
        }
        private static void showAccess(List<string> permitedPlaces)
        {
            foreach(string place in permitedPlaces)
            {
                Console.Write(place + " ");
            }
            Console.WriteLine("");
        }
    }
}
