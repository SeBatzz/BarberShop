using BarberShop.Web.Core;
using BarberShop.Web.Data.Entities;
using BarberShop.Web.Helpers;
using BarberShop.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.Web.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            Response<List<Category>> response = await _categoriesService.GetListAsync();

            return View(response.Result);
        }

        [HttpGet]

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {

            try
            {
                if (!ModelState.IsValid)
                {

                    return View(category);


                }

                Response<Category> response = await _categoriesService.CreateAsync(category);

                if (response.IsSucces)
                {
                    return RedirectToAction(nameof(Index));
                }


                // TODO: MOSTRAR MENSAJE DE ERROR 

                return View(response);


            }
            catch (Exception ex)
            {
                return View(category);
            }


        }

    }
}
