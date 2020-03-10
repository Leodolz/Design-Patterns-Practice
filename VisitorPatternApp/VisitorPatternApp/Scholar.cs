using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternApp
{
    class Scholar : StaffMember
    {
        public string GetName()
        {
            return "Scholar";
        }
        public List<string> GetAccess(StaffVisitor staffVisitor)
        {
            return staffVisitor.getVisitAccess(this);
        }
    }
}
