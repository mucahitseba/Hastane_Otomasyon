using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar.Lib
{
    public class Calısan : Kisi,IMaasAlan
    {
        public decimal SaatlikUcret { set => throw new NotImplementedException(); }

        public decimal Tutar => throw new NotImplementedException();

        public decimal AvansVer()
        {
            throw new NotImplementedException();
        }

        public decimal OdemeYap()
        {
            throw new NotImplementedException();
        }
        
    }
}
