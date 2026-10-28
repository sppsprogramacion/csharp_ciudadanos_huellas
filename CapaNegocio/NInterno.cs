using CapaDatos;
using DAO;
using DAOImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class NInterno
    {
        //RETORNAR INTERNOS X APELLIDO
        public async Task<(List<DInterno>, string error)> RetornarListaInternoXapellido(string apellido)
        {
            IInternoDao internoDao = new InternoDaoImpl();

            (List<DInterno> listaInternos, string errorResponse) = await internoDao.retornarListaInternoXApellido(apellido);
            //await internoDao.retornarListaInternoXApellido(apellido);


            return (listaInternos, errorResponse);
        }
        //FIN RETORNAR INTERNOS POR APELLIDO..................................

        //RETORNAR X APELLIDO GENERAL
        public async Task<(List<DInterno>, string error)> ListaInternosXApellidoGeneral(string apellido)
        {
            IInternoDao internoDao = new InternoDaoImpl();

            (List<DInterno> listaInternos, string error) = await internoDao.ListaInternosXApellidoGeneral(apellido);

            return (listaInternos, error);
        }
        //FIN RETORNAR X APELLIDO GENERAL
        //..............................................................................

    }
}
