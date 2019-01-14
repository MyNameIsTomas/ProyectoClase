using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#region Procedimientos almacenados
/*
create procedure eliminarenfermo(@inscripcion int) as
	delete from ENFERMO where INSCRIPCION = @inscripcion
go

create procedure mostrarenfermos
as
	select * from ENFERMO
go 
*/
#endregion

namespace ProyectoMVCEF.Models {
    public class HelperEnfermos {
        EntidadHospital entidad;
        public HelperEnfermos() {
            entidad = new EntidadHospital();
        }
        public int EliminarEnfermo(int inscripcion) {
            int eliminados = this.entidad.eliminarenfermo(inscripcion);
            return eliminados;
        }
        public List<ENFERMO> GetEnfermos(){
            List<ENFERMO> enfermos = this.entidad.mostrarenfermos().ToList();
            return enfermos;
        }
    }
}