using Microsoft.AspNetCore.Mvc;
using Piranha;
using System;
using BasicWeb.Data.Pages;

namespace BasicWeb.Controllers
{
    public class StartPageController : Controller
    {
        private readonly IApi api;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="api">The current api</param>
        public StartPageController(IApi api) {
            this.api = api;
        }

        /// <summary>
        /// Gets the startpage with the given id.
        /// </summary>
        /// <param name="id">The unique page id</param>
        public IActionResult Index(Guid id) {
            var model = api.Pages.GetById<StartPage>(id);

            return View(model);
        }
    }
}
