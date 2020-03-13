using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class HistoryStudent:IStudent
    {
        private string type = "History Student";
        private List<string> currentKnowledge = new List<string>();
        private string name;
        public HistoryStudent(string name)
        {
            this.name = name;
        }

        public List<string> GetKnowledge()
        {
            return currentKnowledge;
        }

        public string GetName()
        {
            return name + " " + type;
        }

        public void ReforceStudy(string topic)
        {
            int studyIndex = currentKnowledge.FindIndex(knownTopic => knownTopic == topic);
            currentKnowledge[studyIndex] = currentKnowledge[studyIndex] + " REFORCED";
            Console.WriteLine("Reading again topic...");
        }

        public void Study(List<string> topics)
        {
            currentKnowledge.AddRange(topics);
        }
    }
}
