using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_base
{
    public class BigSister
    {
        public void OnAdded (object source, RequestEventArgs e)
        {
            Console.WriteLine("Product Added");
        }
    }
}
