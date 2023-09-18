using OnlineShop.Core.ViewModelProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Interfaces
{

        public interface IProductService
        {
            List<ProductAdminListViewModel> GetAllForAdmin();
        }
 
}
