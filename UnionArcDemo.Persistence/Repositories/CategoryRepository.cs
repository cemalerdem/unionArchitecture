using UnionArcDemo.ApplicationCore.Entities;
using UnionArcDemo.ApplicationCore.Interfaces.Repositories;
using UnionArcDemo.Infrastructure.Repositories.Base;
using UnionArcDemo.Persistence;

namespace UnionArcDemo.Infrastructure.Repositories
{
    public class CategoryRepository : EFRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(NorthwindContext context) : base(context)
        {
            
        }
    }
}