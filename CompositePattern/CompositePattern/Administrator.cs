using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Administrator:IWorker
    {
        private string workStationName;
        private int salary;
        private List<IWorker> assistants;
        public Administrator(string workStationName, int salary)
        {
            this.workStationName = workStationName;
            this.salary = salary;
            assistants = new List<IWorker>();
        }
        public void HireAssistant(IWorker worker)
        {
            assistants.Add(worker);
        }
        public void FireAssistant(IWorker worker)
        {
            assistants.Remove(worker);
        }
        public IList<IWorker> getAssistants()
        {
            return assistants;
        }
        public void describeWork()
        {
            Console.WriteLine("WorkStation: " + workStationName + "\nCareer: " + GetType().Name);
        }
        public void HireAssistant(IList<IWorker> workers)
        {
            foreach (IWorker worker in workers)
            {
                assistants.Add(worker);
            }
        }
        public string workStation()
        {
            return workStationName;
        }
    }
}
