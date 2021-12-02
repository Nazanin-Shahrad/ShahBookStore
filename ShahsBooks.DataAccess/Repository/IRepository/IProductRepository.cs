using ShahsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahsBooks.DataAccess.Repository.IRepository
{
    interface IProductRepository :IRepository<Product>
    {
        void Update(Product product);
    }
}
