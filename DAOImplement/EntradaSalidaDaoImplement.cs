using CapaDatos;
using CommonCache;
using Conexion;
using DAO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAOImplement
{
    public class EntradaSalidaDaoImplement : IEntradaSalidaDao
    {

        private string url_base = MiConexion.getConexion();
        HttpClient httpClient = new HttpClient();


        //LISTA SABANA POR CIUDADANO
        public async Task<(List<DEntradaSalidaSabanaCiudadano>, string error)> ListaEntradaSalidaSabanaXCiudadano(int idCiudadano, string fechaInicio, string fechaFin)
        {
            string token = SessionManager.Token; // Aquí pones tu token real

            List<DEntradaSalidaSabanaCiudadano> listaEntradas = new List<DEntradaSalidaSabanaCiudadano>();

            try
            {
                // Agregar el token en los headers
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage httpResponse = await this.httpClient.GetAsync(url_base + "/entradas-salidas/lista-sabana-xciudadano?id_ciudadano=" + idCiudadano + "&fecha_inicio=" + fechaInicio + "&fecha_fin=" + fechaFin);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    listaEntradas = JsonConvert.DeserializeObject<List<DEntradaSalidaSabanaCiudadano>>(content);
                    return (listaEntradas, null);
                }
                else
                {
                    string errorMessage = await httpResponse.Content.ReadAsStringAsync();
                    var mensaje = JObject.Parse(errorMessage)["message"]?.ToString();
                    return (null, $"Error en la busqueda: {mensaje}");
                }

            }
            catch (HttpRequestException httpRequestException)
            {
                // Capturar errores de la solicitud HTTP
                return (null, $"Error de conexión: {httpRequestException.Message}");
            }
            catch (JsonException jsonException)
            {
                // Capturar errores en la serialización/deserialización de JSON                
                return (null, $"Error inesperado");
            }
            catch (Exception ex)
            {
                // Manejo de errores (log, mensaje al usuario, etc.)
                Console.WriteLine($"Error: {ex.Message}");
                return (null, $"Error inesperado: {ex.Message}");
            }
        }
        //FIN LISTA SABANA POR CIUDADANO
        //---------------------------------------------------------------------------------


        //LISTA SABANA POR INTENRO
        public async Task<(List<DEntradaSalidaSabanaInterno>, string error)> ListaEntradaSalidaSabanaXinterno(int idInterno, string fechaInicio, string fechaFin)
        {
            string token = SessionManager.Token; // Aquí pones tu token real

            List<DEntradaSalidaSabanaInterno> listaEntradas = new List<DEntradaSalidaSabanaInterno>();

            try
            {
                // Agregar el token en los headers
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage httpResponse = await this.httpClient.GetAsync(url_base + "/entradas-salidas/lista-sabana-xinterno?id_interno=" + idInterno + "&fecha_inicio=" + fechaInicio + "&fecha_fin=" + fechaFin);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    listaEntradas = JsonConvert.DeserializeObject<List<DEntradaSalidaSabanaInterno>>(content);
                    return (listaEntradas, null);
                }
                else
                {
                    string errorMessage = await httpResponse.Content.ReadAsStringAsync();
                    var mensaje = JObject.Parse(errorMessage)["message"]?.ToString();
                    return (null, $"Error en la busqueda: {mensaje}");
                }

            }
            catch (HttpRequestException httpRequestException)
            {
                // Capturar errores de la solicitud HTTP
                return (null, $"Error de conexión: {httpRequestException.Message}");
            }
            catch (JsonException jsonException)
            {
                // Capturar errores en la serialización/deserialización de JSON                
                return (null, $"Error inesperado");
            }
            catch (Exception ex)
            {
                // Manejo de errores (log, mensaje al usuario, etc.)
                Console.WriteLine($"Error: {ex.Message}");
                return (null, $"Error inesperado: {ex.Message}");
            }
        }
        //FIN LISTA SABANA POR INTERNO
        //---------------------------------------------------------------------------------



        //SABANA POR CIUDADANO
        public async Task<(DCiudadanoSabanaResponse, string error)> BuscarCiudadanoSabanaXCiudadano(int idCiudadano, string fechaInicio, string fechaFin)
        {
            string token = SessionManager.Token; // Aquí pones tu token real

            DCiudadanoSabanaResponse ciudadanoSabana = new DCiudadanoSabanaResponse();

            try
            {
                // Agregar el token en los headers
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage httpResponse = await this.httpClient.GetAsync(url_base + "/entradas-salidas/sabana-visita-xciudadano?id_ciudadano=" + idCiudadano + "&fecha_inicio=" + fechaInicio + "&fecha_fin=" + fechaFin);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    ciudadanoSabana = JsonConvert.DeserializeObject<DCiudadanoSabanaResponse>(content);
                    return (ciudadanoSabana, null);
                }
                else
                {
                    string errorMessage = await httpResponse.Content.ReadAsStringAsync();
                    var mensaje = JObject.Parse(errorMessage)["message"]?.ToString();
                    return (null, $"Error en la busqueda: {mensaje}");
                }

            }
            catch (HttpRequestException httpRequestException)
            {
                // Capturar errores de la solicitud HTTP
                return (null, $"Error de conexión: {httpRequestException.Message}");
            }
            catch (JsonException jsonException)
            {
                // Capturar errores en la serialización/deserialización de JSON                
                return (null, $"Error inesperado");
            }
            catch (Exception ex)
            {
                // Manejo de errores (log, mensaje al usuario, etc.)
                Console.WriteLine($"Error: {ex.Message}");
                return (null, $"Error inesperado: {ex.Message}");
            }
        }
        //FIN SABANA POR CIUDADANO
        //------------------------------------------------------------------------------------

        //SABANA POR INTERNO
        public async Task<(DInternoSabanaResponse, string error)> BuscarInternoSabanaXInterno(int idInterno, string fechaInicio, string fechaFin)
        {

            string token = SessionManager.Token; // Aquí pones tu token real

            DInternoSabanaResponse internoSabana = new DInternoSabanaResponse();

            try
            {
                // Agregar el token en los headers
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage httpResponse = await this.httpClient.GetAsync(url_base + "/entradas-salidas/sabana-interno-xinterno?id_interno=" + idInterno + "&fecha_inicio=" + fechaInicio + "&fecha_fin=" + fechaFin);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    internoSabana = JsonConvert.DeserializeObject<DInternoSabanaResponse>(content);
                    return (internoSabana, null);
                }
                else
                {
                    string errorMessage = await httpResponse.Content.ReadAsStringAsync();
                    var mensaje = JObject.Parse(errorMessage)["message"]?.ToString();
                    return (null, $"Error en la busqueda: {mensaje}");
                }

            }
            catch (HttpRequestException httpRequestException)
            {
                // Capturar errores de la solicitud HTTP
                return (null, $"Error de conexión: {httpRequestException.Message}");
            }
            catch (JsonException jsonException)
            {
                // Capturar errores en la serialización/deserialización de JSON                
                return (null, $"Error inesperado");
            }
            catch (Exception ex)
            {
                // Manejo de errores (log, mensaje al usuario, etc.)
                Console.WriteLine($"Error: {ex.Message}");
                return (null, $"Error inesperado: {ex.Message}");
            }
        }
        //FIN SABANA POR INTERNO
        //---------------------------------------------------------------




    }
}
