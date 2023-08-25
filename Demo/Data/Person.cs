using RichData.Model.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    public class Person : ModelBase
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public override void Sync()
        {
            RichContext.DbContext.Update<Person>(this);
            RichContext.DbContext.SaveChanges();
        }
    }
}
