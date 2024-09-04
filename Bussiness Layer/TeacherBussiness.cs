using Repository_ConsoleApp.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_ConsoleApp.Bussiness_Layer
{
    internal class TeacherBussiness
    {
        ITeacher Assign;
        public TeacherBussiness(ITeacher assign)
        {
            Assign = assign;
        }
        public List<Teacher> Get()
        {
            return Assign.Get();
        }
        public Teacher Get(int id)
        {
            return Assign.Get(id);
        }
        public bool Add(Teacher model)
        {
            return Assign.Add(model);
        }
        public bool Update(Teacher model)
        {
            return Assign.Update(model);
        }
        public bool Delete(int id)
        {
            return Assign.Delete(id);
        }
    }
}
