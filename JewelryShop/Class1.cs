using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryShop
{
    public partial class gVars
    {
        public static Entities entities = new Entities();
    }
    public partial class Customers
    {
        public override string ToString()
        {
            return FullName;
        }
    }
    public partial class Products
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
