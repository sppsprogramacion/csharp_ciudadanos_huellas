using CapaDatos;
using DAO;
using DAOImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEntradaSalida
    {
        //LISTA SABANA POR CIUDADANO
        public async Task<(List<DEntradaSalidaSabanaCiudadano>, string error)> ListaSabanaXCiudadano(int idCiudadano,string fechaInicio, string fechaFin)
        {
            IEntradaSalidaDao entradaSalidaDao = new EntradaSalidaDaoImplement();

            (List<DEntradaSalidaSabanaCiudadano> listaEntradas, string errorResponse) = await entradaSalidaDao.ListaEntradaSalidaSabanaXCiudadano(idCiudadano, fechaInicio, fechaFin);


            return (listaEntradas, errorResponse);
        }
        //FIN LISTA SABANA POR CIUDADANO..................................

        //LISTA SABANA POR INTERNO
        public async Task<(List<DEntradaSalidaSabanaInterno>, string error)> ListaSabanaXInterno(int idCiudadano, string fechaInicio, string fechaFin)
        {
            IEntradaSalidaDao entradaSalidaDao = new EntradaSalidaDaoImplement();

            (List<DEntradaSalidaSabanaInterno> listaEntradas, string errorResponse) = await entradaSalidaDao.ListaEntradaSalidaSabanaXInterno(idCiudadano, fechaInicio, fechaFin);


            return (listaEntradas, errorResponse);
        }
        //FIN LISTA SABANA POR INTERNO..................................
    }
}
