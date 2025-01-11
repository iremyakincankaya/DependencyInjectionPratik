using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Teacher1 : IOgretmen
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public Teacher1(string ad, string soyad)
        {
            FirstName = ad;
            LastName = soyad;
        }

        public string GetInfo()
        {
            return $"Adı: {FirstName} \r\nSoyadı: {LastName}";
        }
    }
}
