using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Tovar
{
    class Tovar
    {
        public string articul { get; set; }
        public string tovar_name { get; set; }
        public string edinitsa_izmere { get; set; }
        public int price { get; set; }
        public string postavshik { get; set; }
        public string proizvoditel { get; set; }
        public string tovar_category { get; set; }
        public int skidka { get; set; }
        public int count { get; set; }
        public string opisanie { get; set; }
        public string photo { get; set; }

        public Tovar(string articul, string tovar_name, string edinitsa_izmere, int price, string postavshik, string proizvoditel, string tovar_category, int skidka, int count, string opisanie, string photo)
        {
            this.articul = articul;
            this.tovar_name = tovar_name;
            this.edinitsa_izmere = edinitsa_izmere;
            this.price = price;
            this.postavshik = postavshik;
            this.proizvoditel = proizvoditel;
            this.tovar_category = tovar_category;
            this.skidka = skidka;
            this.count = count;
            this.opisanie = opisanie;
            this.photo = photo;
        }
    }
}
