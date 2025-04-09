using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MulloJosue_LigaPro.Models;
using MulloJosue_LigaPro.Repositories;

namespace MulloJosue_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            EquipoRepository equipoRepository = new EquipoRepository(); 
            var equipos = equipoRepository.DevuelveListadoEquipos();
            return View(equipos);
        }
    }
}
