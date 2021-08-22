using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.İslemSınıfları
{
    public class Bolme:IBolme
    {
        public double Bol(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }
    }
}
