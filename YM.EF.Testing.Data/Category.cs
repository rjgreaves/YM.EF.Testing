﻿using System.Collections.Generic;

namespace YM.EF.Testing.Data
{
    public class Category
    {

        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
