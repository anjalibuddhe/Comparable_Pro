using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableProject
{
    public class Product:IComparable<Product>
    {
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int CompareTo(Product p)
        {
          if(this.price <p.price)
            {
                return -1;

            }
          else if(this.price >p.price)
            {
                return 1;
            }
          else { return 0; }
        }

        public override string ToString()
        {
            return $"{name}-{price}";
        }
    }
}
