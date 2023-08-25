using Microsoft.EntityFrameworkCore.Diagnostics;

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichData.Model.Core
{
    public abstract class ModelBase : IModel
    {
        protected RichContext? RichContext;

        public void SetRichContextByInterceptionData(MaterializationInterceptionData materializationData)
        {
            RichContext = new RichContext(materializationData);
        }

        public abstract void Sync();
    }
}
