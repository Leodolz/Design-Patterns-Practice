using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternApp
{
    class Manager : StaffMember
    {
        public string GetName()
        {
            return "Manager";
        }
        public List<string> GetAccess(StaffVisitor staffVisitor)
        {
            return staffVisitor.getVisitAccess(this);
        }
    }
}
