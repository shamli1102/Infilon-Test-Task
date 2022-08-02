using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        WebApplicationEntities1 _db;

        public HomeController()
        {
            _db = new WebApplicationEntities1();
        }

        // GET: Home
        public ActionResult Index()
        {
            var json = "";

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://jsonplaceholder.typicode.com/todos/");
                //json = json.Replace("[","").Replace("]","");
                List<dynamic> models = JsonConvert.DeserializeObject<List<dynamic>>(json);
                foreach (dynamic im in models)
                {

                }
            }
                    ViewData.Model = _db.Employee.ToList();
            return View();
        }
    }
}