using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Tutor
    {
        private IStudent currentStudent;
        public Tutor(IStudent newStudent)
        {
            currentStudent = newStudent;
        }
        public void GiveHomework(List<string> topics)
        {
            currentStudent.Study(topics);
        }
        public bool GiveTest(List<string> topicsToTest)
        {
            bool isAproved = true;
            List<string> studentLearnings = currentStudent.GetKnowledge();
            foreach(string topicToTest in topicsToTest)
            {
                if (studentLearnings.Find(topic => topic.StartsWith(topicToTest)) == null)
                {
                    isAproved = false;
                    Console.WriteLine("Failed on topic: " + topicToTest);
                    break;
                }
            }
            return isAproved;
        }
        public void ReforceStudy(string topicToReforce)
        {
            currentStudent.ReforceStudy(topicToReforce);
        }
        public void ShowStudentProgress()
        {
            Console.WriteLine("Student Progress:");
            Console.WriteLine("---------------------------------");
            foreach(string topic in currentStudent.GetKnowledge())
            {
                Console.WriteLine(topic);
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
