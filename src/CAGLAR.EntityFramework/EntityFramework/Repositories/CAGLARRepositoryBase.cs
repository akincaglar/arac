using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CAGLAR.EntityFramework.Repositories
{
    public abstract class CAGLARRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CAGLARDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CAGLARRepositoryBase(IDbContextProvider<CAGLARDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CAGLARRepositoryBase<TEntity> : CAGLARRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CAGLARRepositoryBase(IDbContextProvider<CAGLARDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
