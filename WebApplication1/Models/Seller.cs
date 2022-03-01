using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BaseSalary { get; set; }
        public DateTime BirthDate { get; set; }
        public Department department { get; set; }
        public ICollection<SalesRecord> sales { get; set; } = new List<SalesRecord>();
        public Seller()
        {

        }

        public Seller(int id, string name, string email, double baseSalary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            this.department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            sales.Add(sr);
        }
        public void RemoveSaless(SalesRecord sr)
        {
            sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
