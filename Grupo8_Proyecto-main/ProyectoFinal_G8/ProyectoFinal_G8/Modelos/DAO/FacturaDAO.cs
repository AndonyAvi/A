using ProyectoFinal_G8.Modelos.Entidades;
using ProyectoFinal_G8.Vistas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Modelos.DAO
{
    public class FacturaDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        FacturaView vista;
        private void Mostrar(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM PAQUETES WHERE ID= @ID", MiConexion);
            comando.Parameters.AddWithValue("@ID", vista.txtIDCliente.Text);
            MiConexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                //DENTRO DE [" "] VAN LOS NOMBRES DE LAS COLUMNAS DE SQL
                vista.txtNumPaquete.Text = registro[" "].ToString();
                vista.txtFecha.Text = registro[" "].ToString();
            }
            


        }
    }
}
