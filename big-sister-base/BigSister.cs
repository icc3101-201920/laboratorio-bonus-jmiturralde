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
            Product lastProduct = e.RequestCart[e.RequestCart.Count-1];

            foreach(Product var in e.RequestShopList)
            {
                if(var.Name == lastProduct.Name)
                {
                    if (var.Stock > 0)
                    {
                        Console.WriteLine("Product confirmed by Big Sister");
                        var.Stock -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Product decline by Big Sister");
                        Console.WriteLine(var.Name);
                        Console.WriteLine(var.Stock);
                    }
                }
                else
                {
                }
            }
        }
    }
}
