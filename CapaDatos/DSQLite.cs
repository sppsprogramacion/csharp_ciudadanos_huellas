using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DSQLite
    {
        private readonly string carpetaDatos;
        private readonly string rutaBase;
        private readonly string cadenaConexion;

        public DSQLite()
        {
            carpetaDatos = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ),
                "AtencionCiudadano"
            );

            rutaBase = Path.Combine(
                carpetaDatos,
                "huellas.db"
            );

            cadenaConexion =
                $"Data Source={rutaBase};Version=3;";
        }

        public void Inicializar()
        {
            if (!Directory.Exists(carpetaDatos))
            {
                Directory.CreateDirectory(carpetaDatos);
            }

            bool baseNueva = !File.Exists(rutaBase);

            if (baseNueva)
            {
                SQLiteConnection.CreateFile(rutaBase);
            }

            CrearTablas();
        }

        private void CrearTablas()
        {
            using (SQLiteConnection conexion =
                   new SQLiteConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS huellas
                (
                    id_huella_ciudadano INTEGER PRIMARY KEY,
                    ciudadano_id INTEGER NOT NULL,
                    dedo_id INTEGER NOT NULL,
                    huella BLOB NOT NULL
                );

                CREATE TABLE IF NOT EXISTS sincronizacion
                (
                    id INTEGER PRIMARY KEY,
                    ultima_version INTEGER NOT NULL
                );
            ";

                using (SQLiteCommand comando =
                       new SQLiteCommand(sql, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void GuardarHuella(int idHuella,int ciudadanoId,int dedoId,byte[] huella)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = @"INSERT INTO huellas(id_huella_ciudadano, ciudadano_id,dedo_id,huella)
                                VALUES(@idHuella, @ciudadanoId, @dedoId, @huella);";

                using (SQLiteCommand comando = new SQLiteCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@idHuella", idHuella);

                    comando.Parameters.AddWithValue("@ciudadanoId", ciudadanoId);

                    comando.Parameters.AddWithValue("@dedoId", dedoId);

                    comando.Parameters.Add("@huella", System.Data.DbType.Binary).Value = huella;

                    comando.ExecuteNonQuery();
                }
            }
        }

        public byte[] ObtenerHuella(int idHuella)
        {
            using (SQLiteConnection conexion =
                   new SQLiteConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = @"
                    SELECT huella
                    FROM huellas
                    WHERE id_huella_ciudadano = @idHuella;
                ";

                using (SQLiteCommand comando =new SQLiteCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@idHuella",
                        idHuella
                    );

                    object resultado = comando.ExecuteScalar();

                    if (resultado == null ||
                        resultado == DBNull.Value)
                    {
                        return null;
                    }

                    return (byte[])resultado;
                }
            }
        }
    }
}
