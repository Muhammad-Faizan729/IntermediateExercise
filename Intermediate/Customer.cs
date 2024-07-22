using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> orders;

        public Customer()
        {
            orders = new List<Order>();
        }

        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this()
        {
            this.Id=id;
            this.Name = name;
        }

        public void Prompt()
        {
            orders = new List<Order>();
        }
    }
}
