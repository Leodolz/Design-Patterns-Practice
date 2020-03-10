using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternApp
{
    class Senior : StaffMember
    {
        public string GetName()
        {
            return "Senior";
        }
        public List<string> GetAccess(StaffVisitor staffVisitor)
        {
            return staffVisitor.getVisitAccess(this);
        }
    }
}
