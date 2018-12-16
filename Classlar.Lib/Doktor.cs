using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classlar.Lib
{
    public class Doktor:Calısan
    {
        private Branslar _brans;
        private Hemsire _hemsire;
        private string _ad, _soyad, _telefon, _email, _tckn;
        private List<Randevu> _doktorRandevuList = new List<Randevu>();

        public List<Randevu> DoktorRandevuList
        {
            get => this._doktorRandevuList;
            set => this._doktorRandevuList = value;
        }

        public override Hemsire Hemsire { get=>this._hemsire; set=>this._hemsire = value; }
        public override Branslar Brans { get => this._brans; set => this._brans = value; }

        public override string Ad
        {
            get => this._ad;
            set
            {
                NameValid(value, "Ad");
                value = value.Trim();
                this._ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public override string Soyad
        {
            get => this._soyad;
            set
            {
                NameValid(value, "Soyad");
                value = value.Trim();
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public override string Telefon
        {
            get => this._telefon;
            set
            {
                if (!value.StartsWith("0"))
                    throw new Exception("Telefon numarasi 0 ile baslamali");
                if (value.Length != 11)
                    throw new Exception("Telefon numaraniz 11 hane olmali");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("Telefon numaraniz sadece rakamlardan olusmalidir");
                }

                this._telefon = value;
            }
        }
        public override string Email
        {
            get => this._email;
            set
            {
                Regex rgx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!rgx.IsMatch(value))
                    throw new Exception("Lutfen bir email adresi giriniz");
                this._email = value;
            }
        }
        public override string TCKN
        {
            get => this._tckn;
            set
            {
                if (value.Length != 11)
                    throw new Exception("TCKN 11 haneli olmalidir");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("TCKN sadece rakamlardan olusmalidir");
                }

                this._tckn = value;
            }
        }

        protected override void NameValid(string value, string propertyName)
        {
            foreach (char harf in value)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception($"{propertyName} girisi sadece harf ve bosluklarla yapilmalidir.");

            }
        }
    }
}
