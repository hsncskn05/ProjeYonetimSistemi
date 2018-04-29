using Business.Abstract;
using Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GorevDurumManagement:IGorevDurumService
    {
        EFGorevDurum _gorevdurumManagement = new EFGorevDurum();

        public void Add(Entity.EntityFramework.GorevDurum entity)
        {
            _gorevdurumManagement.Add(entity);
        }

        public void Delete(Entity.EntityFramework.GorevDurum entity)
        {
            _gorevdurumManagement.Delete(entity);
        }

        public void Update(Entity.EntityFramework.GorevDurum entity)
        {
            _gorevdurumManagement.Update(entity);
        }

        public Entity.EntityFramework.GorevDurum Get(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.GorevDurum, bool>> filter = null)
        {
            return _gorevdurumManagement.Get(filter);
        }

        public ICollection<Entity.EntityFramework.GorevDurum> GetAll(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.GorevDurum, bool>> filter = null)
        {
            return _gorevdurumManagement.GetAll(filter);
        }
    }
}
