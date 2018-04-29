using Business.Abstract;
using Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjeManagement:IProjeService
    {
        EFProje _projeManagement = new EFProje();
        public void Add(Entity.EntityFramework.Proje entity)
        {
            _projeManagement.Add(entity);
        }

        public void Delete(Entity.EntityFramework.Proje entity)
        {
            _projeManagement.Delete(entity);
        }

        public void Update(Entity.EntityFramework.Proje entity)
        {
            _projeManagement.Update(entity);
        }

        public Entity.EntityFramework.Proje Get(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.Proje, bool>> filter = null)
        {
            return _projeManagement.Get(filter);
        }

        public ICollection<Entity.EntityFramework.Proje> GetAll(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.Proje, bool>> filter = null)
        {
            return _projeManagement.GetAll(filter);
        }
    }
}
