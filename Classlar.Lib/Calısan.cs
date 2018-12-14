using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar.Lib
{
    public abstract class Calısan : Kisi, IMaasAlan
    {
        //private string _ad, _soyad, _telefon, _email, _tckn;

        private decimal _maas;
        public decimal Maas
        {
            get => this._maas;

            protected set
            {
                this._maas = value;
            }
        }
        //public override string Ad { get; set; }
        //public override string Soyad { get; set; }

        //public override string Telefon { get; set; }
        //public override string Email { get; set; }
        //public override string TCKN { get; set; }

        public virtual Hemsire Hemsire { get; set; }
        public abstract Branslar Brans { get; set; }
        public decimal SaatlikUcret { get; set; }

        public decimal Tutar { get;set; }

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
