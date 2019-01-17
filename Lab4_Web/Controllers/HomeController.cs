using Lab4_Data;
using Lab4_Data.Entity;
using Lab4_Web.Models;
using System.Web.Mvc;


namespace Lab4_Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ResponseForm(ResponseModel responseModel)
        {
            using (Context db = new Context())
            {
                Response newResp = new Response { Username = responseModel.Username, Email = responseModel.Email, Message = responseModel.Message };
                db.Responses.Add(newResp);
                db.SaveChanges();

            }
            return View("Index");
        }
    }
}
