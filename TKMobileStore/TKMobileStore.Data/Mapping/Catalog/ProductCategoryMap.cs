﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobileStore.Entities.Catalog;

namespace TKMobileStore.Data.Mapping.Catalog
{
    public partial class ProductCategoryMap : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMap()
        {
            this.ToTable("Product_Category_Mapping");
            this.HasKey(pc => pc.Id);

            this.HasRequired(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            this.HasRequired(pc => pc.Category)
                .WithMany()
                .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
