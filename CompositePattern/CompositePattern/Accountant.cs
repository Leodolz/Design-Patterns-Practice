using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Accountant : IWorker
    {
        private string department;
        private int salary;
        private List<IWorker> assistants;
        public Accountant(string department, int salary)
        {
            this.department = department;
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
            Console.WriteLine("Department: " + department + "\nCareer: " + GetType().Name);
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
            return department;
        }
    }
}
