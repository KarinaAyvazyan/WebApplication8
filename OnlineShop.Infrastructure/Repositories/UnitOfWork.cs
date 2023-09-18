using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineShopDbContext _context;
        public UnitOfWork(OnlineShopDbContext context)
        {
            _context = context; 
        }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
