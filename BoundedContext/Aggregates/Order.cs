using BoundedContext.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundedContext.Aggregates
{
    public class Order
    {
        //change private acessors
        public int Id { get; set; }
        public List<Product> Products { get; set; }
    }
}
