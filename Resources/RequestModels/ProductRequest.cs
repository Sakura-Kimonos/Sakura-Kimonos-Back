﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Resources.RequestModels
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
        public string Season { get; set; }
        public string Pattern { get; set; }
        public int Stock { get; set; }
        public ProductItem ToProductItem()
        {
            var product = new ProductItem();

            product.Name = Name;
            product.Description = Description;
            product.Price = Price;
            product.Category = Category;
            product.Material = Material;
            product.Season = Season;
            product.Pattern = Pattern;
            product.Stock = Stock;


            product.AddedDate = DateTime.Now;
            product.UpdateDate = DateTime.Now;
            product.IsActive = true;
            product.IsPublic = true;
            return product;
        }
    }
}
