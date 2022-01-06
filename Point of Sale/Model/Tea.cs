using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.Model
{
    public class Tea
    {
        public int Id { get; set; }
        public string TeaName { get; set; }
        public int TeaQuantity { get; set; }
        public double TeaPrice { get; set; }

        public string DisplayInfo
        {
            get { return string.Format("{0} - ${1}   -   {2}", TeaName, TeaPrice, TeaQuantity + " in stock"); }
        }

        public string CartInfo
        {
            get { return string.Format("{0} - ${1}", TeaName, TeaPrice); }
        }
    }
}
