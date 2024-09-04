using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_ConsoleApp.Data_Access_Layer
{
    public class TeacherAssign : ITeacher
    {
        List<Teacher> listTeacher = new List<Teacher>()
        {
            new Teacher(10,"Sourov Khan", "Geology"),
            new Teacher(20,"Arman Ahmed", "Philosophy"),
            new Teacher(30,"Sohel Rana", "Bangla"),
            new Teacher(35,"Wahiduzzaman", "English"),
            new Teacher(38,"Kamrul Islam", "History"),
        };
        public bool Add(Teacher model)
        {
            listTeacher.Add(model);
            return true;
        }

        public bool Delete(int enrollId)
        {
            bool isExecuted = false;
            Teacher Customer = listTeacher.Where(x => x.EnrollId == enrollId).FirstOrDefault();
            if (Customer != null)
            {
                listTeacher.Remove(Customer);
                isExecuted = true;
            }
            return isExecuted;
        }

        public List<Teacher> Get()
        {
            return listTeacher.OrderBy(x => x.TeacherName).ToList();
        }

        public Teacher Get(int enrollId)
        {
            Teacher teacher = listTeacher.Where(x => x.EnrollId == enrollId).FirstOrDefault();
            return teacher;
        }

        public bool Update(Teacher model)
        {
            bool isExecuted = false;
            Teacher Customer = listTeacher.Where(x => x.EnrollId == model.EnrollId).FirstOrDefault();
            if (Customer != null)
            {
                listTeacher.Remove(Customer);
                listTeacher.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
