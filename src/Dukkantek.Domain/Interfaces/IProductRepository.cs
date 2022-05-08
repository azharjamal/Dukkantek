using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dukkantek.Domain.Models.Inventories;


namespace Dukkantek.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {

        Task<IEnumerable<ProductStatus>> GetProductStatus(int categoryId);

    }

}
