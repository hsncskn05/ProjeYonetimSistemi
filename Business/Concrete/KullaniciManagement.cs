using Business.Abstract;
using Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KullaniciManagement:IKullaniciService
    {
        EFKullanici _kullaniciManagement = new EFKullanici();
        public void Add(Entity.EntityFramework.Kullanici entity)
        {
            _kullaniciManagement.Add(entity);
        }

        public void Delete(Entity.EntityFramework.Kullanici entity)
        {
            _kullaniciManagement.Delete(entity);
        }

        public void Update(Entity.EntityFramework.Kullanici entity)
        {
            _kullaniciManagement.Update(entity);
        }

        public Entity.EntityFramework.Kullanici Get(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.Kullanici, bool>> filter = null)
        {
            return _kullaniciManagement.Get(filter);
        }

        public ICollection<Entity.EntityFramework.Kullanici> GetAll(System.Linq.Expressions.Expression<Func<Entity.EntityFramework.Kullanici, bool>> filter = null)
        {
            return _kullaniciManagement.GetAll(filter);
        }
    }
}
