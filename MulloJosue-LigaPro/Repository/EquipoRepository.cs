using MulloJosue_LigaPro.Models;

namespace MulloJosue_LigaPro.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            equipos.Add(new Equipo { Id = 1, Nombre = "Barcelona SC", PartidosJugados = 10, PartidosGanados = 7, PartidosPerdidos = 2, PartidosEmpatados = 1 });
            equipos.Add(new Equipo { Id = 2, Nombre = "Emelec", PartidosJugados = 10, PartidosGanados = 5, PartidosPerdidos = 3, PartidosEmpatados = 2 });
            equipos.Add(new Equipo { Id = 3, Nombre = "LDU Quito", PartidosJugados = 10, PartidosGanados = 6, PartidosPerdidos = 2, PartidosEmpatados = 2 });
            equipos.Add(new Equipo { Id = 4, Nombre = "El Nacional", PartidosJugados = 10, PartidosGanados = 4, PartidosPerdidos = 4, PartidosEmpatados = 2 });
            equipos.Add(new Equipo { Id = 5, Nombre = "Delfín", PartidosJugados = 10, PartidosGanados = 3, PartidosPerdidos = 5, PartidosEmpatados = 2 });
            equipos.Add(new Equipo { Id = 6, Nombre = "Aucas", PartidosJugados = 10, PartidosGanados = 2, PartidosPerdidos = 6, PartidosEmpatados = 2 });
            equipos.Add(new Equipo { Id = 7, Nombre = "Mushuc Runa", PartidosJugados = 10, PartidosGanados = 1, PartidosPerdidos = 7, PartidosEmpatados = 2 });
            return equipos;
        }
    }
}
