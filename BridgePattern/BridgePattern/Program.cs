using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudent mathStudent = new MathStudent("James");
            IStudent historyStudent = new HistoryStudent("Claire");
            Tutor generalTutor = new Tutor(mathStudent);
            TutorMathStudent(generalTutor);
            Console.WriteLine(mathStudent.GetName());
            Console.ReadKey();
            generalTutor = new Tutor(historyStudent);
            TutorHistoryStudent(generalTutor);
            Console.WriteLine(historyStudent.GetName());
            Console.ReadKey();
        }
        private static void TutorMathStudent(Tutor generalTutor)
        {
            List<string> firstLesson = new List<string> { "Calculus 1", "Trigonometry", "Geometry" };
            List<string> genericExam = new List<string> { "Calculus 1", "Trigonometry REFORCED", "Geometry", "Calculus 2" };
            List<string> secondLesson = new List<string> { "Calculus 2" };
            string reforceSubject = firstLesson[1];
            genericTutoring(generalTutor, firstLesson, genericExam, secondLesson, reforceSubject);
        }
        private static void TutorHistoryStudent(Tutor generalTutor)
        {
            List<string> firstLesson = new List<string> { "World War 1", "US Civil War", "Discovery of America" };
            List<string> secondLesson = new List<string> { "History of Presidents" };
            string reforceSubject = firstLesson[1];
            List<string> genericExam = new List<string> { "World War 1", "US Civil War REFORCED", "Discovery of America", "History of Presidents" };
            genericTutoring(generalTutor, firstLesson, genericExam, secondLesson, reforceSubject);
        }
        private static void genericTutoring(Tutor generalTutor, List<string> firstLesson, List<string> genericExam, List<string> secondLesson, string reforceSubject)
        {
            generalTutor.GiveHomework(firstLesson);
            generalTutor.ShowStudentProgress();
            if (!generalTutor.GiveTest(genericExam))
                Console.WriteLine("Failed Exam, study more and reinforce");
            generalTutor.ReforceStudy(reforceSubject);
            generalTutor.GiveHomework(secondLesson);
            if (generalTutor.GiveTest(genericExam))
                Console.WriteLine("Exam Succeded! Good Job!");
            generalTutor.ShowStudentProgress();
        }
    }
}
