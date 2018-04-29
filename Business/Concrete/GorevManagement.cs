using Business.Abstract;
using Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GorevManagement:IGorevService
    {
        EFGorev _gorevManagement = new EFGorev();
        public void Add(Entity.EntityFramework.Gorev entity)
        {
            _gorevManagement.Add(entity);
        }

        public void Delete(Entity.EntityFramework.Gorev entity)
        {
            _gorevManagement.Delete(entity);
        }

        public void Update(Entity.EntityFramework.Gorev entity)
        {
            _gorevManagement.Update(entity);
        }

        public Entity.EntityFramework.Gorev Get(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.Gorev, bool>> filter = null)
        {
            return _gorevManagement.Get(filter);
        }

        public ICollection<Entity.EntityFramework.Gorev> GetAll(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.Gorev, bool>> filter = null)
        {
            return _gorevManagement.GetAll(filter);
        }
    }
}
