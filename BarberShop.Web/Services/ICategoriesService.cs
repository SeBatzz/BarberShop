using BarberShop.Web.Core;
using BarberShop.Web.Data;
using BarberShop.Web.Data.Entities;
using BarberShop.Web.Helpers;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Web.Services
{
    public interface ICategoriesService
    {

        public Task<Response<Category>> CreateAsync(Category model);

        public Task<Response<List<Category>>> GetListAsync();
        
    }


    public class CategoriesService  : ICategoriesService
    {

        private readonly DataContext _context;

        public CategoriesService(DataContext context)
        {
            _context = context;
        }

        public  async Task<Response<Category>> CreateAsync(Category model)
        {
            try
            {
                Category category = new Category
                {

                    CategoryName = model.CategoryName,
                    Description = model.Description,
                    Trending = model.Trending,
                    AgeGroup = model.AgeGroup
                    
                };

                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();

                return ResponseHelper<Category>.MakeResponseSuccess(category, "! Categoria creada con exito ¡");
                
            }
            catch (Exception ex)
            {
                return ResponseHelper<Category>.MakeResponseFail(ex);

            }
        }

        public async Task<Response<List<Category>>> GetListAsync()
        {

            try
            {
                List<Category> categories  = await _context.Categories.ToListAsync();

                

                return ResponseHelper<List<Category>>.MakeResponseSuccess(categories);

            }
            catch (Exception ex)
            {
                return ResponseHelper<List<Category>>.MakeResponseFail(ex);

            }
        }

    }
}