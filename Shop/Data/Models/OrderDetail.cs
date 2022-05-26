using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderID { get; set; }

        public int mangaID { get; set; }

        public double price { get; set; }

        public virtual Manga manga { get; set; }

        public virtual Order order { get; set; }
        
    }
}
