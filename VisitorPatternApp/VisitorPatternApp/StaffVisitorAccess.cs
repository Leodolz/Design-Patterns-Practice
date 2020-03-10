using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternApp
{
    class StaffVisitorAccess : StaffVisitor
    {
        public List<string> getVisitAccess(Scholar scholar)
        {
            return new List<string> {"Cafeteria","Lobby"};
        }

        public List<string> getVisitAccess(Junior junior)
        {
            return new List<string> { "Cafeteria", "Lobby", "1st Floor" };
        }

        public List<string> getVisitAccess(Senior senior)
        {
            return new List<string> { "Cafeteria", "Lobby", "1st Floor", "2nd Floor" };
        }

        public List<string> getVisitAccess(Manager manager)
        {
            return new List<string> { "Cafeteria", "Lobby", "1st Floor", "2nd Floor", "Manager Office"};
        }
    }
}
