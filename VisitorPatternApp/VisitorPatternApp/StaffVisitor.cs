using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternApp
{
    interface StaffVisitor
    {
        List<string> getVisitAccess(Scholar scholar);
        List<string> getVisitAccess(Junior junior);
        List<string> getVisitAccess(Senior senior);
        List<string> getVisitAccess(Manager manager);
    }
}
