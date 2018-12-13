using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classlar.Lib
{
    public abstract class Kisi
    {
        //private string _ad, _soyad, _telefon, _email, _tckn;

        public abstract string Ad{ get; set; }
        public abstract string Soyad { get; set; }

        public abstract string Telefon { get; set; }
        public abstract string Email { get; set; }
        public abstract string TCKN { get; set; }

        protected abstract void NameValid(string value, string propertyName);

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }
    }
}
