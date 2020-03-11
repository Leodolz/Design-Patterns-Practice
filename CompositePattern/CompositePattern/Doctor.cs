using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Doctor:IWorker
    {
        private string rank;
        private string specialty;
        private int salary;
        private List<IWorker> assistants;
        public Doctor(string rank, string specialty, int salary)
        {
            this.rank = rank;
            this.specialty = specialty;
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
            Console.WriteLine("Specialty: "+specialty+"\nCareer: "+GetType().Name);
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
            return specialty;
        }
    }
}
