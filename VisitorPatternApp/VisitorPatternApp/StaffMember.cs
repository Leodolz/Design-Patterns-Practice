using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternApp
{
    interface StaffMember
    {
        string GetName();
        List<string> GetAccess(StaffVisitor staffVisitor);
    }
}
