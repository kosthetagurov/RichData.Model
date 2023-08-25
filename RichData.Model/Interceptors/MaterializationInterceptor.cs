using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

using RichData.Model.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichData.Model.Interceptors
{
    public class MaterializationInterceptor : IMaterializationInterceptor
    {
        public object InitializedInstance(MaterializationInterceptionData materializationData, object instance)
        {
            if (instance is ModelBase)
            {
                var convertedInstance = (ModelBase)instance;
                convertedInstance.SetRichContextByInterceptionData(materializationData);
                return convertedInstance;
            }

            return instance;
        }
    }
}
