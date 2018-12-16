using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar.Lib
{
    public class Randevu
    {
        private Hasta randevuAlanHasta;
        private Doktor randevuAlinanDoktor;
        private DateTime randevuSaati;
        private Branslar randevuAlinanServis;

        public Hasta RandevuAlanHasta { get =>this.randevuAlanHasta; set=>this.randevuAlanHasta = value; }
        public Doktor RandevuAlinanDoktor { get=>this.randevuAlinanDoktor; set=>this.randevuAlinanDoktor = value; }
        public DateTime RandevuSaati { get=>this.randevuSaati; set=>this.randevuSaati = value; }
        public Branslar RandevuAlinanServis { get=>this.randevuAlinanServis; set=>this.randevuAlinanServis = value; }
    }
}
