using Microsoft.EntityFrameworkCore;

using RichData.Model.Interceptors;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichData.Model.DependencyInjection
{
    public static class DbContextOptionsBuilderExtensions
    {
        public static DbContextOptionsBuilder AddMateriazationInterceptor(this DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(new MaterializationInterceptor());
            return optionsBuilder;
        }
    }
}
