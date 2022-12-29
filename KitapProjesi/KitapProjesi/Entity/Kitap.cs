using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapProjesi.Entity
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public DateTime KitapBasimYili { get; set; }
        public int SayfaSayisi { get; set; }
        public string YazarAdi { get; set; }
        public string IsbnNumarasi { get; set; }

        public override string ToString()
        {
            return $"Kitap Adı: {this.KitapAdi} - Yazar Adı : {this.YazarAdi}";
        }

    }
}
