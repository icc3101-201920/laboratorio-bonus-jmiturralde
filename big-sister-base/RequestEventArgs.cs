using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_base
{
    public class RequestEventArgs:EventArgs
    {
        public List<Product> RequestShopList { get; set; }
    }
}
