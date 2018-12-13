using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar.Lib
{
   public class Hemsire:Calısan,IMaasAlan
    {
        public Branslar _brans;
        public bool _atandiMi = false;

        public override Branslar Brans { get => this._brans; set => this._brans = value; }
    }
}
