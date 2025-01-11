using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ClassRoom
    {
        private readonly IOgretmen _teacher;
        //ClassRoom sınıfının yapıcısına (constructor) Teacher sınıfının bir örneğini (instance) parametre olarak geçin. (Constructor Injection)
        public ClassRoom(IOgretmen teacher)
        {
            _teacher = teacher;
        }

        public string GetInfoTeacher()
        {
            return _teacher.GetInfo();
        }
       
    }
}
