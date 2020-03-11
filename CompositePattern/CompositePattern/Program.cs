using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(IWorker worker in GetWorkers())
            {
                Console.WriteLine("-----------------------------------------------------------");
                worker.describeWork();
                Console.WriteLine("Assistants:---------------------------");
                foreach(IWorker assistant in worker.getAssistants())
                {
                    assistant.describeWork();
                }
            }
            Console.ReadLine();
        }
        static List<IWorker> GetWorkers()
        {
            IWorker CEO = new Administrator("CEO", 120000);
            IWorker ChiefDoctor = new Doctor("Chief Doctor", "Neuro-surgery", 80000);
            IWorker Secretary = new Accountant("Secretary", 20000);
            IWorker HospitalManager = new Administrator("Management", 65000);
            IWorker Auditor = new Administrator("Accountancy", 50000);
            IWorker GeneralDoctor1 = new Doctor("General Doctor", "General Surgery", 50000);
            IWorker GeneralDoctor2 = new Doctor("General Doctor", "Cardiologist", 50000);
            IWorker Nurse1 = new Doctor("Student Doctor", "Nursery", 20000);
            IWorker Nurse2 = new Doctor("Student Doctor", "Nursery", 20000);
            IWorker HRManager = new Administrator("Human Resources", 40000);
            CEO.HireAssistant(new List<IWorker>() { ChiefDoctor, HospitalManager });
            ChiefDoctor.HireAssistant(new List<IWorker>() { GeneralDoctor1, GeneralDoctor2 });
            GeneralDoctor1.HireAssistant(new List<IWorker>() { Nurse1, Nurse2 });
            GeneralDoctor2.HireAssistant(new List<IWorker>() { Nurse1, Nurse2 });
            HospitalManager.HireAssistant(new List<IWorker>() { HRManager, Auditor });
            HRManager.HireAssistant(Secretary);
            Auditor.HireAssistant(Secretary);
            return  new List<IWorker> {CEO,ChiefDoctor,Secretary,HospitalManager,
                Auditor,GeneralDoctor1,GeneralDoctor2,Nurse1,Nurse2,HRManager};
        }
    }
}
