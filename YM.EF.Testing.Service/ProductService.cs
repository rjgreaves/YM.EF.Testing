using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using YM.EF.Testing.Data;

namespace YM.EF.Testing.Service
{
    public class ProductService
    {
        public List<ProductModel> Get(string category)
        {
            using (var context = new ShopDataContext())
            {
                return context.Products
                    .Where(x => x.Category.Name == category)
                    .Select(x =>
                        new ProductModel
                        {
                            Id = x.Id,
                            CategoryName = x.Category.Name,
                            Price = x.Name.StartsWith("P") ? x.Price * 0.5 : x.Price,
                            Name = x.Name
                        })
                    .ToList();
            }
        }


        public List<CategoryModel> GetCategories()
        {
            using(var context = new ShopDataContext())
            {
                var categories = context.Categories.Include(c => c.Products);
                return
                    (
                    from c in categories
                    select new CategoryModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Products = 
                            (
                            from p in c.Products
                            select new ProductModel
                            {
                                Id = p.Id,
                                Name = p.Name,
                                CategoryName = c.Name,
                                Price = p.Price
                            }
                            ).ToList()
                    }
                    ).ToList();
            }
        }
    }
}
