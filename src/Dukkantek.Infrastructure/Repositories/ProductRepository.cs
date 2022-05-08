
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dukkantek.Domain.Interfaces;
using Dukkantek.Domain.Models.Inventories;
using Dukkantek.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
namespace Dukkantek.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DukkantekDbContext context) : base(context) { }

        public async Task<IEnumerable<ProductStatus>> GetProductStatus(int categoryId)
        {
            if (categoryId > 0)
            {
                var query = (from p in Db.Products
                             group p by new { p.CategoryId } into g
                             select new
                             {
                                 g.Key.CategoryId,
                                 InStock = g.Sum(p => p.Status ==  Status.InStock ? 1 : 0),
                                 Sold = g.Sum(p => p.Status == Status.Sold ? 1 : 0),
                                 Damaged = g.Sum(p => p.Status == Status.Damaged ? 1 : 0)
                             })
                               .Select(x => new ProductStatus { CategoryId = x.CategoryId, InStock = x.InStock, Sold = x.Sold, Damaged = x.Damaged })
                               .Where(x=> x.CategoryId == categoryId );


                return await query.ToListAsync();
            }
            else
            {
                var query = (from p in Db.Products
                             group p by p.Status into g
                             select new
                             {
                                 InStock = g.Sum(p => p.Status == Status.InStock ? 1 : 0),
                                 Sold = g.Sum(p => p.Status == Status.Sold ? 1 : 0),
                                 Damaged = g.Sum(p => p.Status == Status.Damaged ? 1 : 0)
                             })
               .Select(x => new ProductStatus { InStock = x.InStock, Sold = x.Sold, Damaged = x.Damaged })
                 ;


                return await query.ToListAsync();
            }       
        }

        //public async Task<IEnumerable<Book>> SearchBookWithCategory(string searchedValue)
        //{
        //    return await Db.Books.AsNoTracking()
        //        .Include(b => b.Category)
        //        .Where(b => b.Name.Contains(searchedValue) ||
        //                    b.Author.Contains(searchedValue) ||
        //                    b.Description.Contains(searchedValue) ||
        //                    b.Category.Name.Contains(searchedValue))
        //        .ToListAsync();
        //}
        }

}
