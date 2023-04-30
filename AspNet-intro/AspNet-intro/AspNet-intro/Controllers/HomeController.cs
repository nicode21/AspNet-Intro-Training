using Microsoft.AspNetCore.Mvc;

namespace AspNet_intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = {1, 2, 3, 4, 5, 6, 7, 8};
            return View(nums) /*Json(new { name = "Resul",surname = "Hesenov"})*/ /*Ok("Success")*/ /*NotFound()*/ /*BadRequest()*/;
        }


      /*  public string Index(*//*int num, string num2*/ /*int id*//*)
        {
            return "This is a home page"*//*+ num + " - " + num2*//*;
        }

        public string Test(int id)
        { 
            return "This is a test action --- " + id;
        }*/
    }
}
