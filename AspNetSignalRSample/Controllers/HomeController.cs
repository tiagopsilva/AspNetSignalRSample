using System.Web.Mvc;
using AspNetSignalRSample.Hubs;
using Microsoft.AspNet.SignalR;

namespace AspNetSignalRSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotifyAll()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            hubContext.Clients.All.writeMessage("Called from anoter locale");
            return View();
        }
    }
}