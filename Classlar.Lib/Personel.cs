using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar.Lib
{
    public class Personel:Calısan
    {
        private Branslar _brans;
        public Gorevler Gorev { get; set; }
        public override Branslar Brans { get => this._brans; set => this._brans = value; }
    }
}
