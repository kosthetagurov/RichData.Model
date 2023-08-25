using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichData.Model.Core
{
    public class RichContext
    {
        public DbContext DbContext { get; }

        public RichContext(MaterializationInterceptionData materializationData)
        {
            DbContext = materializationData.Context;
        }
    }
}
