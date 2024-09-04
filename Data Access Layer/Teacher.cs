using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_ConsoleApp.Data_Access_Layer
{
    public class Teacher
    {
        public int EnrollId;
        public string TeacherName;
        public string Subject;
        public Teacher()
        {

        }
        public Teacher(int enrollId, string teachername, string subject)
        {
            EnrollId = enrollId;
            TeacherName = teachername;
            Subject = subject;
        }
    }
}
