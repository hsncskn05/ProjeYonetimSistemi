using Core;
using Data.Abstract;
using Data.Context;
using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class EFGorev : EFRepositoryBase<ProjeContext,Gorev>,IGorev
    {
  
    }
}
