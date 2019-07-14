using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
   public class Pharmacy
    {
        private static int _id;

        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        private List<Medicine> medicines;

        public Pharmacy(string name)
        {
            _id++;
            ID = _id;
            Name = name;
            medicines = new List<Medicine>()
            {
                new Medicine{Name="Analgin",Price="5",Typemedicine="Bas agrisi"},
                new Medicine{Name="Spazmalqon",Price="6",Typemedicine="Bas agrisi"},
                new Medicine{Name="Unisom",Price="7",Typemedicine="Yuxu dermani"}
            };
        }
        public List<Medicine> GetMedicines()
        {
            return medicines;
        }
        public void AddMedicine(Medicine m)
        {
            medicines.Add(m);
        }
        public void DeleteMedicine(int id)
        {
            for (int i = 0; i < medicines.Count; i++)
            {
                if (id == medicines[i].ID)
                {
                    medicines.RemoveAt(i);
                    return;
                }
            }
        }
        public void EditMedicine(int id, string name,string price,string type)
        {
            Medicine medicine = GetMedicine(id);
            medicine.Name = name;
            medicine.Price = price;
            medicine.Typemedicine = type;
        }


        public Medicine GetMedicine(int id)
        {
            Medicine result = null;
            for (int i = 0; i < medicines.Count; i++)
            {
                if (id == medicines[i].ID)
                {
                    result = medicines[i];
                }
            }
            return result;
        }




    }
}
