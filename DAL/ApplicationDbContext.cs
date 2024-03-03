using OnionArcExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ApplicationDbContext
    {
        static List<Product> productList = new List<Product>
        {
            new() {Id = new Guid(),Description = "Anadolu",Name = "alinazik",Price = 200, Stock= 2},
            new() {Id = new Guid(),Description = "Ege",Name = "Ciğer şiş",Price = 200, Stock= 2},
            new() {Id = new Guid(),Description = "Akdeniz",Name = "Kavurma",Price = 200, Stock= 2},
            new() {Id = new Guid(),Description = "Akdeniz",Name = "Tas Kebabı",Price = 200, Stock= 2},
            new() {Id = new Guid(),Description = "Karadeniz",Name = "Lahmacun",Price = 200, Stock= 2},
            new() {Id = new Guid(),Description = "Tatli",Name = "Sütlaç",Price = 200, Stock= 2},
            new() {Id = new Guid(),Description = "Tatli",Name = "Kazandibi",Price = 200, Stock= 2},

        };
        public static List<Product> ProductList => productList;
    }
}
