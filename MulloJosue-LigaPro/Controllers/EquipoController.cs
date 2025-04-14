using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MulloJosue_LigaPro.Models;
using MulloJosue_LigaPro.Repositories;

namespace MulloJosue_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }

        public IActionResult Info()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            return View(equipos);
        }



        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos()
                                      .OrderByDescending(e => e.PartidosGanados)
                                      .ToList();
            return View(equipos);
        }


        public ActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var equipo = _repository.DevuelveListadoEquipos().FirstOrDefault(e => e.Id == id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }


        public ActionResult Edit(int Id)
        {
            Equipo equipo = _repository.DevuelveEquipoPorId(Id);
            return View(equipo);
        }
        [HttpPost]
        public JsonResult Update([FromBody] Equipo equipo)
        {
            var actualizado = _repository.ActualizarEquipo(equipo.Id, equipo);
            if (actualizado)
            {
                return Json(new { success = true, message = "Equipo actualizado correctamente." });
            }
            return Json(new { success = false, message = "No se pudo actualizar el equipo." });
        }





        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            try
            {
                // Proceso de guardar  
                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
