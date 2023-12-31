﻿using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Repositories
{
 
        public class OnlineShopDbContext : DbContext
        {
            public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> opt) : base(opt)
            {

            }
            public DbSet<Product> Products { get; set; }
            public DbSet<ProductImage> ProductImages { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Vendor> Vendors { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Cart> Carts { get; set; }
            public DbSet<Customer> Customers { get; set; }
        }
    }

