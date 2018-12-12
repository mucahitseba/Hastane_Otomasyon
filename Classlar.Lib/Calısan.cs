using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar.Lib
{
    public abstract class Calısan : Kisi, IMaasAlan
    {
        private decimal _maas;
        public decimal Maas
        {
            get => this._maas;

            protected set
            {
                this._maas = value;
            }
        }
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
