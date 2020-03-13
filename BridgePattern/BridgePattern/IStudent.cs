using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    interface IStudent
    {
        void Study(List<string> topics);
        List<string> GetKnowledge();
        string GetName();
        void ReforceStudy(string topic);
    }
}
