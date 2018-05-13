using PracticeAPI.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class PracticeController : Controller
    {
        private readonly IPracticeLogic _practiceApi;

        public PracticeController(IPracticeLogic practiceApi)
        {
            _practiceApi = practiceApi;
        }
        public async Task<ActionResult> Index()
        {
            try
            {
                var results = await _practiceApi.GetAll();
                return View(results);
            }
            catch (Exception e)
            {
                return View("Error", e);
            }
        }
    }
}