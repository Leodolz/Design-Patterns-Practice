using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class MathStudent : IStudent
    {
        private string name;
        public MathStudent(string name)
        {
            this.name = name;
        }
        private string type = "Math Student";
        private List<string> currentKnowledge = new List<string>();
        public List<string> GetKnowledge()
        {
            return currentKnowledge;
        }

        public string GetName()
        {
            return name+" "+type;
        }

        public void ReforceStudy(string topic)
        {
            int studyIndex = currentKnowledge.FindIndex(knownTopic => knownTopic == topic);
            currentKnowledge[studyIndex] = currentKnowledge[studyIndex] + " REFORCED";
            Console.WriteLine("Practicing more Math Examples...");
        }

        public void Study(List<string> topics)
        {
            currentKnowledge.AddRange(topics);
        }
    }
}
