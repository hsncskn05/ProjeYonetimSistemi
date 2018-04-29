using Business.Abstract;
using Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AtananKisiManagement:IAtananKisiService
    {
        EFAtananKisi _atananKisiManagement = new EFAtananKisi();
        public void Add(Entity.EntityFramework.AtananKisi entity)
        {
            _atananKisiManagement.Add(entity);
        }

        public void Delete(Entity.EntityFramework.AtananKisi entity)
        {
            _atananKisiManagement.Delete(entity);
        }

        public void Update(Entity.EntityFramework.AtananKisi entity)
        {
            _atananKisiManagement.Update(entity);
        }

        public Entity.EntityFramework.AtananKisi Get(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.AtananKisi, bool>> filter = null)
        {
            return _atananKisiManagement.Get(filter);
        }

        public ICollection<Entity.EntityFramework.AtananKisi> GetAll(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.AtananKisi, bool>> filter = null)
        {
            return _atananKisiManagement.GetAll(filter);
        }
    }
}
