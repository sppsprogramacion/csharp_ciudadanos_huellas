using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IEntradaSalidaDao
    {
        Task<(List<DEntradaSalidaSabanaCiudadano>, string error)> ListaEntradaSalidaSabanaXCiudadano(int idCiudadano, string fechaInicio, string fechaFin);
        Task<(List<DEntradaSalidaSabanaInterno>, string error)> ListaEntradaSalidaSabanaXinterno(int idInterno, string fechaInicio, string fechaFin);
        Task<(DCiudadanoSabanaResponse, string error)> BuscarCiudadanoSabanaXCiudadano(int idCiudadano, string fechaInicio, string fechaFin);
        Task<(DInternoSabanaResponse, string error)> BuscarInternoSabanaXInterno(int idInterno, string fechaInicio, string fechaFin);

    }
}
