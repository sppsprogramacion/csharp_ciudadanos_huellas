using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCiudadanoSabanaResponse
    {
        public int id_ciudadano { get; set; }
        public int dni { get; set; }
        public string nombre_visita { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
        public string domicilio { get; set; }
        public string foto { get; set; }

        public List<DEntradaSalidaSabanaCiudadano> listaEntradasResponse { get; set; }
        public List<DVisitaInterno> listaVinculosResponse { get; set; }
    }
}
