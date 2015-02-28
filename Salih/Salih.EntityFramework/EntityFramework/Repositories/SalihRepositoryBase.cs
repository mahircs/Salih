using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Salih.EntityFramework.Repositories
{
    public abstract class SalihRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SalihDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SalihRepositoryBase(IDbContextProvider<SalihDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SalihRepositoryBase<TEntity> : SalihRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SalihRepositoryBase(IDbContextProvider<SalihDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
