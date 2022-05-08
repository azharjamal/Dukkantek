using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dukkantek.Domain.Interfaces;
using Dukkantek.Domain.Models;
using Dukkantek.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Dukkantek.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(DukkantekDbContext context) : base(context) { }
    }
}
