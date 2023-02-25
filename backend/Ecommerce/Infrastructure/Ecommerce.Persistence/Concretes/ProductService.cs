using Ecommerce.Application.Abstractions;
using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new() {Id=Guid.NewGuid(),Name="Product 1",Price=150,Stock=10},
                new() {Id=Guid.NewGuid(),Name="Product 2",Price=250,Stock=10},
                new() {Id=Guid.NewGuid(),Name="Product 3",Price=350,Stock=10},
                new() {Id=Guid.NewGuid(),Name="Product 4",Price=450,Stock=10},
                new() {Id=Guid.NewGuid(),Name="Product 5",Price=550,Stock=10}
            };
    }
}
