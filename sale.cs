using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u301_prac_03
{
    internal class sale
    {
        public string Textbook { get; internal set; }
        public object Subject { get; internal set; }
        public string Category { get; set; }

        public object PurchasedPrice { get; internal set; }

        public object SalePrice { get; internal set; }

        public string Rating { get; internal set; }

    }
}
