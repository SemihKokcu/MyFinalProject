using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //=> bu klasör için global değişken isimlendirme standardına göre _ ile başlar
        public InMemoryProductDal()
        {
            //veri tabanından geliyormuş gibi
            _products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Tv",CategoryId=1,UnitPrice=300,UnitsInStock=7},
                new Product { ProductId = 2, ProductName = "Bardak",CategoryId=2,UnitPrice=5,UnitsInStock=24},
                new Product { ProductId = 3, ProductName = "Telefon",CategoryId=1,UnitPrice=500,UnitsInStock=123},
                new Product { ProductId = 4, ProductName = "Çatal",CategoryId=2,UnitPrice=2,UnitsInStock=23},
                new Product { ProductId = 5, ProductName = "Kaşık",CategoryId=2,UnitPrice=2,UnitsInStock=45},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null; // başta boş referenası yok

            //foreach (Product p in _products)
            //{
            //    if (p.ProductId == product.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            //LINQ
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            
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
            return _products.Where(p => p.CategoryId==categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUptade = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUptade.ProductName = product.ProductName;
            productToUptade.UnitPrice = product.UnitPrice;
            productToUptade.UnitsInStock = product.UnitsInStock;   
            productToUptade.CategoryId = product.CategoryId;

        }
    }
}
