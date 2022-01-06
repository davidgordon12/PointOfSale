using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_Sale.Model;

namespace Point_of_Sale
{
    public class Inventory
    {
        public List<Tea> Teas = new List<Tea>();

        public Inventory()
        {
            Teas.Add(new Tea { Id = 1, TeaName = "Green Tea", TeaQuantity = 10, TeaPrice = 1.00 });
            Teas.Add(new Tea { Id = 2, TeaName = "Oolong Tea", TeaQuantity = 10, TeaPrice = 1.00 });
            Teas.Add(new Tea { Id = 3, TeaName = "Black Tea", TeaQuantity = 10, TeaPrice = 1.50 });
            Teas.Add(new Tea { Id = 4, TeaName = "Red Tea", TeaQuantity = 10, TeaPrice = 2.00 });
            Teas.Add(new Tea { Id = 5, TeaName = "White Tea", TeaQuantity = 10, TeaPrice = 2.50 });
            
        }
    }
}
