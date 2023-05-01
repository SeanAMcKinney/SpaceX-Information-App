using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SpaceXDAL.EntityModles;
using SpaceXSL.Service_Actions;
using SpaceXUI.Models;

namespace SpaceXUI.Controllers
{
    public class CrewController : Controller
    {
        public IActionResult CrewInfo()
        {
            string crewJson = Actions.GetJson(1);
            List<CrewVM>? crewInfo = JsonConvert.DeserializeObject<List<CrewVM>>(crewJson);
            return View(crewInfo.ToList());

        }
    }
}
