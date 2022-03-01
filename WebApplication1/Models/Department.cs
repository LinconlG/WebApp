using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        
        public Department()
        {

        }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void AddSeller(Seller sl)
        {
            Sellers.Add(sl);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
