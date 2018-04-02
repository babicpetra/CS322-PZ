using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CS322_PZ_PetraBabic2223.Models;

namespace CS322_PZ_PetraBabic2223.Controllers
{
    public class Item
    {
        private Product pr = new Product();
        private int quantitiy;

        public Item()
        {

        }


        public Item(Product product, int quantitiy)
        {
            this.Pr = product;
            this.Quantitiy = quantitiy;
        }

        public Product Pr { get => pr; set => pr = value; }
        public int Quantitiy { get => quantitiy; set => quantitiy = value; }
    }
}