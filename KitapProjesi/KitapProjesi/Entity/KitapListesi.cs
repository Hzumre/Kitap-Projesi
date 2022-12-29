using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapProjesi.Entity
{
    public class KitapListesi
    {
        private static List<Kitap> _kitap = new List<Kitap>();

        public void Add(Kitap kitap)
        {
            _kitap.Add(kitap);
        }

        public List<Kitap> GetAll()
        {
            return _kitap;
        }

        public void Remove(Kitap kitap)
        {
            _kitap.Remove(kitap);
        }

       

    }
}
