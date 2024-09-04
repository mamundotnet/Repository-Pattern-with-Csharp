using Repository_ConsoleApp.Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_ConsoleApp.Data_Access_Layer
{
    public interface ITeacher
    {
        List<Teacher> Get();
        Teacher Get(int enrollId);
        bool Add(Teacher model);
        bool Update(Teacher model);
        bool Delete(int enrollId);
    }
}
