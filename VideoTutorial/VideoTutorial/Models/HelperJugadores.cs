using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoTutorial.Models {
    public class HelperJugadores {
        HOSPITALEntities1 entidad;
        public HelperJugadores() {
            this.entidad = new HOSPITALEntities1();
        }
        /*-------------*/
        public List<InformacionJugadores> GetPaginarJugadores(String[] equipos, int posicion, ref int totalregistros) {
            totalregistros = this.entidad.InformacionJugadores.Count();
            //var consulta = (from datos in entidad.InformacionJugadores select datos).OrderBy(z => z.JNOMBRE).Skip(posicion).Take(3).ToList();
            //var consulta = from datos in entidad.InformacionJugadores select datos;
            if (equipos == null) {
                return (from datos in entidad.InformacionJugadores select datos).OrderBy(z => z.JNOMBRE).Skip(posicion).Take(3).ToList();
            } else {
                return (from datos in entidad.InformacionJugadores where equipos.Contains((String)datos.NOM_EQUIPO) select datos).OrderBy(z => z.JNOMBRE).Skip(posicion).Take(3).ToList();
            }
            //List<InformacionJugadores> jugadores = consulta;
            //return jugadores;
        }
        /*-------------*/
        public List<InformacionJugadores> GetPaginarJugadoresMultiple(String[] equipos, int posicion, ref int totalregistros) {
            totalregistros = this.entidad.InformacionJugadores.Count();
            var consulta = (from datos in entidad.InformacionJugadores where equipos.Contains((String)datos.NOM_EQUIPO) select datos).OrderBy(z => z.JNOMBRE).Skip(posicion).Take(3).ToList();
            return consulta.ToList();
        }
        /*-------------*/
        public List<EQUIPO> GetEquipos() {
            var consulta = from datos in entidad.EQUIPO select datos;
            List<EQUIPO> equipos = consulta.ToList();
            return equipos;
        }
        /*-------------*/
        //public List<InformacionJugadores> GetPaginarJugadoresEquipo(int posicion, ref int totalregistros, string equipo) {
        //    var consulta = (from datos in entidad.InformacionJugadores where  select datos).OrderBy(z => z.JNOMBRE).Skip(posicion).Take(3).ToList();
        //    List<InformacionJugadores> jugadores = consulta;
        //    return jugadores;
        //}
    }
}