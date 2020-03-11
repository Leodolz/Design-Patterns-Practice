using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    interface IWorker
    {
        void HireAssistant(IWorker worker);
        void HireAssistant(IList<IWorker> workers);
        void FireAssistant(IWorker worker);
        IList<IWorker> getAssistants();
        void describeWork();
        string workStation();
    }
}
