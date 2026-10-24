using ArithmeticMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArithmeticMVC.Controllers
{
    public class HomeController : Controller

{
        public IActionResult Index()
        {
            return View(new ArithmeticModel());
        }

        [HttpPost]
        public IActionResult Index(ArithmeticModel model)
        {
            if (ModelState.IsValid)
            {
                switch (model.Operation)
                {
                    case "Add":
                        model.Result = model.Number1 + model.Number2;
                        break;
                    case "Subtract":
                        model.Result = model.Number1 - model.Number2;
                        break;
                    case "Multiply":
                        model.Result = model.Number1 * model.Number2;
                        break;
                    case "Divide":
                        if (model.Number2 == 0)
                        {
                            model.ErrorMessage = "Error: Division by zero!";
                        }
                        else
                        {
                            model.Result = model.Number1 / model.Number2;
                        }
                        break;
                }
            }

            return View(model);
        }
    }
}
