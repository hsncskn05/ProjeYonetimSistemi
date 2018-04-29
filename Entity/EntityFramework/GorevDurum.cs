using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityFramework
{
    public class GorevDurum : IEntity
    {
        public int id { get; set; }
        public string Gorev { get; set; }
    }
}
