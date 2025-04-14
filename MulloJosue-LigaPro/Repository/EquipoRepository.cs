using MulloJosue_LigaPro.Models;

namespace MulloJosue_LigaPro.Repositories
{
    public class EquipoRepository
    {
        private static List<Equipo> Equipos; // Cambiamos a static para mantener los datos en memoria

        public EquipoRepository()
        {
            if (Equipos == null) // Solo inicializamos la lista si es null
            {
                Equipos = new List<Equipo>
                {
                    new Equipo { Id = 1, Nombre = "Barcelona SC", PartidosJugados = 10, PartidosGanados = 7, PartidosPerdidos = 2, PartidosEmpatados = 1, LogoPath = "/imgs/logos-equipos/barcelona-logo.png", Descripcion = "Fundado en 1925 en Guayaquil, es uno de los clubes más populares y exitosos de Ecuador." },
                    new Equipo { Id = 2, Nombre = "Emelec", PartidosJugados = 10, PartidosGanados = 5, PartidosPerdidos = 3, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/emelec-logo.png", Descripcion = "Establecido en 1929 en Guayaquil, eterno rival de Barcelona SC y protagonista del Clásico del Astillero." },
                    new Equipo { Id = 3, Nombre = "LDU Quito", PartidosJugados = 10, PartidosGanados = 6, PartidosPerdidos = 2, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/ligadequito-logo.png", Descripcion = "Fundado en 1930, es uno de los clubes más laureados del país, conocido como 'La U' o 'Albos'." },
                    new Equipo { Id = 4, Nombre = "El Nacional", PartidosJugados = 10, PartidosGanados = 4, PartidosPerdidos = 4, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/nacional-logo.png", Descripcion = "Fundado en 1964, conocido como 'Los Puros Criollos', juega solo con futbolistas ecuatorianos." },
                    new Equipo { Id = 5, Nombre = "Delfín", PartidosJugados = 10, PartidosGanados = 3, PartidosPerdidos = 5, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/delfin-logo.png", Descripcion = "Club de Manta fundado en 1989, logró su primer título nacional en 2019." },
                    new Equipo { Id = 6, Nombre = "Aucas", PartidosJugados = 10, PartidosGanados = 2, PartidosPerdidos = 6, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/aucas-logo.png", Descripcion = "Club quiteño fundado en 1945, conocido como 'Papá Aucas', con una hinchada fiel y tradicional." },
                    new Equipo { Id = 7, Nombre = "Mushuc Runa", PartidosJugados = 10, PartidosGanados = 1, PartidosPerdidos = 7, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/mushucruna-logo.png", Descripcion = "Fundado en 2003, representa a la comunidad indígena y es conocido como 'El Ponchito'." },
                    new Equipo { Id = 8, Nombre = "Independiente del Valle", PartidosJugados = 10, PartidosGanados = 6, PartidosPerdidos = 2, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/independientedelvalle-logo.png", Descripcion = "Fundado en 1958 en Sangolquí, se destaca por su formación de juveniles y logros internacionales." },
                    new Equipo { Id = 9, Nombre = "Universidad Católica", PartidosJugados = 10, PartidosGanados = 4, PartidosPerdidos = 3, PartidosEmpatados = 3, LogoPath = "/imgs/logos-equipos/universidadcatolica-logo.png", Descripcion = "Club de Quito fundado en 1963, conocido como 'El Trencito Azul', constante en la Serie A." },
                    new Equipo { Id = 10, Nombre = "Deportivo Cuenca", PartidosJugados = 10, PartidosGanados = 3, PartidosPerdidos = 4, PartidosEmpatados = 3, LogoPath = "/imgs/logos-equipos/deportivocuenca-logo.png", Descripcion = "Fundado en 1971, representa a Cuenca y fue campeón nacional en 2004." },
                    new Equipo { Id = 11, Nombre = "Técnico Universitario", PartidosJugados = 10, PartidosGanados = 2, PartidosPerdidos = 5, PartidosEmpatados = 3, LogoPath = "/imgs/logos-equipos/tecnicouniversitario-logo.png", Descripcion = "Club ambateño fundado en 1971, conocido como 'El Rodillo Rojo'." },
                    new Equipo { Id = 12, Nombre = "Macará", PartidosJugados = 10, PartidosGanados = 3, PartidosPerdidos = 4, PartidosEmpatados = 3, LogoPath = "/imgs/logos-equipos/macara-logo.png", Descripcion = "Fundado en 1939 en Ambato, es conocido como 'El Celeste'." },
                    new Equipo { Id = 13, Nombre = "Orense", PartidosJugados = 10, PartidosGanados = 2, PartidosPerdidos = 6, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/orense-logo.png", Descripcion = "Club joven fundado en 2009 en Machala, conocido como 'El Auriverde'." },
                    new Equipo { Id = 14, Nombre = "Manta FC", PartidosJugados = 10, PartidosGanados = 3, PartidosPerdidos = 5, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/manta-logo.png", Descripcion = "Club manabita fundado en 1998, conocido como 'Los Atuneros'." },
                    new Equipo { Id = 15, Nombre = "Libertad FC", PartidosJugados = 10, PartidosGanados = 1, PartidosPerdidos = 7, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/libertad-logo.png", Descripcion = "Club lojeño fundado en 2017, uno de los más recientes en llegar a Serie A." },
                    new Equipo { Id = 16, Nombre = "Vinotinto Ecuador", PartidosJugados = 10, PartidosGanados = 2, PartidosPerdidos = 6, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/vinotinto-logo.png", Descripcion = "Equipo reciente de Quito que busca consolidarse en la élite del fútbol ecuatoriano." }
                };
            }
        }

        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            return Equipos;
        }

        public Equipo DevuelveEquipoPorId(int id)
        {
            return Equipos.FirstOrDefault(e => e.Id == id);
        }

        public bool ActualizarEquipo(int id, Equipo equipoActualizado)
        {
            var equipo = Equipos.FirstOrDefault(e => e.Id == id);
            if (equipo != null)
            {
                equipo.PartidosJugados = equipoActualizado.PartidosJugados;
                equipo.PartidosGanados = equipoActualizado.PartidosGanados;
                equipo.PartidosEmpatados = equipoActualizado.PartidosEmpatados;
                equipo.PartidosPerdidos = equipoActualizado.PartidosPerdidos;
                return true;
            }
            return false;
        }
    }

}
