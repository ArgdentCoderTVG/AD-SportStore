using Microsoft.AspNetCore.Mvc;
using SportStore.ViewModels;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        //Action method: GET-request -> returns create-view
        public IActionResult Create()
        {
            ProductBindingModel model = new ProductBindingModel();
            return View(model);
        }

        //Action method: POST-request -> processes data (redirect to success or return input)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductBindingModel userModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View(userModel);
        }

        //Action method: GET-request -> returns success-view
        public IActionResult Success()
        {
            return View();
        }
    }
}
