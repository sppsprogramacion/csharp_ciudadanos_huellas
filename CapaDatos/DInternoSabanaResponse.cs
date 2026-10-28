using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DInternoSabanaResponse
    {
        public int id_interno { get; set; }
        public int prontuario { get; set; }
        public string nombre_interno { get; set; }
        public string foto { get; set; }
        public string estado_procesal { get; set; }
        public string jurisdiccion { get; set; }
        public string organismo { get; set; }
        public DateTime fecha_alojamiento { get; set; }

        public List<DEntradaSalidaSabanaInterno> listaEntradasResponse { get; set; }
        public List<DVisitaInterno> listaVinculosResponse { get; set; }
    }
}
