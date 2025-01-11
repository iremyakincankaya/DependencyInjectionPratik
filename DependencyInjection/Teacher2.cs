using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Teacher2 : IOgretmen
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Yas { get; set; }


        public Teacher2(string ad, string soyad,int yas)
        {
            FirstName = ad;
            LastName = soyad;
            Yas = yas;
        }

        public string GetInfo()
        {
            return $"Adı: {FirstName} \r\nSoyadı: {LastName} \r\nYaşı: {Yas}";
        }
    }
}
