using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class Exam
    {
        public string NameExam;
        public int TimeExam;
        public DateTime NowExam;


        public void UploadExam(string nameExam, int timeExam)
        {
            TimeExam = timeExam;
            NameExam = nameExam;
            NowExam = DateTime.Now;

        }

        public void GitUploadExam()
        {
            Console.WriteLine($"The Name Exam:{NameExam}, Time Video:{TimeExam}, Time is Upload Video:{NowExam}");
        }
    }
}