using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Tovars
{
   public class Tovar
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

       public Tovar(string articul_)
        {
            articul = articul_;
        }
    }
}
