using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{
                    ProductId=1,
                    CategoryId=1,
                    ProductName="Mobilya",
                    UnitPrice=450,
                    UnitsInStock=90
                },
                new Product{
                    ProductId=2,
                    CategoryId=2,
                    ProductName="Bilgisayar",
                    UnitPrice=4500,
                    UnitsInStock=50
                },
                new Product{
                    ProductId=3,
                    CategoryId=1,
                    ProductName="İnegöl Mobilya",
                    UnitPrice=500,
                    UnitsInStock=190
                },
                new Product{
                    ProductId=4,
                    CategoryId=3,
                    ProductName="Buzdolabı",
                    UnitPrice=200,
                    UnitsInStock=40
                },
                new Product{
                    ProductId=5,
                    CategoryId=2,
                    ProductName="Telefon",
                    UnitPrice=3200,
                    UnitsInStock=250
                }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integreted Query
            //=> - Lambda

            Product productToDelete;
            
            //foreach (var p in _products)
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate;
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
