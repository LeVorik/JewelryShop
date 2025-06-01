using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace JewelryShop
{
    public partial class gVars
    {
        public static Entities entities = new Entities();
        public static Users cur_user;
        public static Frame MainFrame;
        public static MainWindow MainWindow;
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
    public partial class Users
    {
        public override string ToString()
        {
            return FullName;
        }
    }
}
