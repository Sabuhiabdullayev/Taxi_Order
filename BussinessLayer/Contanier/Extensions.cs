using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Contanier
{
    public static class Extensions
    {
        public static void ContanierDependencies(this IServiceCollection Services)
        {
          Services.AddScoped<IOrderServices, OrderManager>();
            Services.AddScoped<IOrderDal, EfOrderDal>();
            Services.AddScoped<IContactUsServices, ContactUsManager>();
            Services.AddScoped<IContactUsDal, EfContactUsDal>();
        }

        }
}
