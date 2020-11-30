using Helishop.Folder.Interfaces;
using Helishop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helishop.Controllers
{
    public class HelicoptersController : Controller
    {
        private readonly IAllHelicopters _allHelicopters;
        private readonly IHelicopterCategory _allCategories;

        public HelicoptersController(IAllHelicopters iAllHelicopters, IHelicopterCategory iHelicoptersCategory)
        {
            _allHelicopters = iAllHelicopters;
            _allCategories = iHelicoptersCategory;
        }

        public ViewResult List()
        {
            HelicoptersListViewModel model = new HelicoptersListViewModel();
            model.getAllHelicopters = _allHelicopters.Helicopters;
            model.currentCategory = "Вертолеты";

            return View(model);
        }

        public ActionResult main()
        {
            return View();
        }
        public ActionResult contacts()
        {
            return View();
        }
    }
}
