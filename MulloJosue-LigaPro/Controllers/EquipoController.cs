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

        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            equipos = equipos.OrderByDescending(e => e.PartidosGanados).ToList();

            return View(equipos);
        }

        public ActionResult Create()
        {
            return View();
        }



        public ActionResult Edit(int Id)
        {
     
            Equipo equipo = _repository.DevuelveEquipoPorId(Id);

            
            return View(equipo);
        }

        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            try
            {
                //Proceso de guardar
                
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
