using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
   public class Medicine
    {
        private static int _id;

        public int ID { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

        public string Typemedicine { get; set; }

        public Medicine()
        {
            _id++;
            ID = _id;
        }
        public override string ToString()
        {
            return $"{ID} {Name} {Price} {Typemedicine}";
        }
    }
}
