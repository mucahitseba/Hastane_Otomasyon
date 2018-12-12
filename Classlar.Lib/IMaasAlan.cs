using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar.Lib
{
    public interface IMaasAlan
    {
        decimal SaatlikUcret { set; }
        decimal Tutar { get; }
        decimal AvansVer();
        decimal OdemeYap();
    }
}
