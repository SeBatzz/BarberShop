using BarberShop.Web.Data;
using BarberShop.Web.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Web
{
    public static class CustomConfiguration 
    {

        public static WebApplicationBuilder AddCustomBuilderConfiguration(this WebApplicationBuilder builder)
        {

            // Data Context

            builder.Services.AddDbContext<DataContext>(configuration =>
            {
                configuration.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));

            });



            // Services Here

            AddServices(builder);


            return builder;


        }
<<<<<<< HEAD

        public static void AddServices(this  WebApplicationBuilder builder) 
        { 
            builder.Services.AddScoped<ICategoriesService, CategoriesService>();
        
=======
        public static void AddServices(this WebApplicationBuilder builder)
        {
            //services
            builder.Services.AddScoped<IHaircutServices, HaircutServices>();
>>>>>>> a41a47080a74ab7afd1457f9ad35400e517e3ca5
        }
    }       
}
