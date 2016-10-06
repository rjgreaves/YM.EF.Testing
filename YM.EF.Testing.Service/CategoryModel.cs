using System;
using System.Collections.Generic;

namespace YM.EF.Testing.Service
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<ProductModel> Products { get; set; }
    }
}
