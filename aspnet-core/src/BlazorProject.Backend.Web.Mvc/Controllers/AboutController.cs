using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BlazorProject.Backend.Controllers;

namespace BlazorProject.Backend.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : BackendControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
