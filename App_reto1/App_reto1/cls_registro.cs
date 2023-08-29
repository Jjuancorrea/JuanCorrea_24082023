using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace App_reto1
{
    public class cls_registro
    {
        private string str_mensaje;
        public void fnt_agregar(string Pkcodigo, string Nombre, string apellido, string contacto, string correo, string direccion, string empresa,
            string salario, string monto, string meses)
        {
            if (Pkcodigo == "" || Nombre == "" || apellido == "" || contacto == "" || correo == "" || direccion == "" || empresa == "" || salario == ""
                 || monto == "" || meses == "")
            {
                str_mensaje = "No puede mandar campos vacíos";
            }
            else
            {
                try
                {
                    cls_conexion objConecta = new cls_conexion();
                    SqlCommand con = new SqlCommand("solicitudes", objConecta.connection);
                    con.CommandType = CommandType.StoredProcedure;
                    con.Parameters.AddWithValue("@id", Pkcodigo);
                    con.Parameters.AddWithValue("@nombre", Nombre);
                    con.Parameters.AddWithValue("@apellido", apellido);
                    con.Parameters.AddWithValue("@contacto", contacto);
                    con.Parameters.AddWithValue("@correo", correo);
                    con.Parameters.AddWithValue("@direccion", direccion);
                    con.Parameters.AddWithValue("@empresa_labora", empresa);
                    con.Parameters.AddWithValue("@salario", salario);
                    con.Parameters.AddWithValue("@monto", monto);
                    con.Parameters.AddWithValue("@meses", meses);
                    objConecta.connection.Open();
                    con.ExecuteNonQuery();
                    objConecta.connection.Close();
                    str_mensaje = "Registro exitoso";
                }
                catch (Exception) { str_mensaje = "Este registro ya existe"; }
            }
        }
        public string getMensaje() { return this.str_mensaje; }
    }
 }