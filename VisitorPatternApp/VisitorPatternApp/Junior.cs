using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternApp
{
    class Junior : StaffMember
    {
        public string GetName()
        {
            return "Junior";
        }
        public List<string> GetAccess(StaffVisitor staffVisitor)
        {
            return staffVisitor.getVisitAccess(this);
        }
    }
}
