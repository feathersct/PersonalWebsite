using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;
using PersonalWebsite.Services;

namespace PersonalWebsite.Controllers
{
    public class ProjectController : Controller
    {
        IPWRepository _db;

        public ProjectController(IPWRepository db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var projects = _db.ReadAllProjects();

            return View(projects);
        }

        public IActionResult Details(int id)
        {
            Project project = _db.ReadProject(id);
            return View(project);
        }
    }
}