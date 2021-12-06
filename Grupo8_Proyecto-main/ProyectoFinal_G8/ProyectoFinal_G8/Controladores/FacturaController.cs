using ProyectoFinal_G8.Modelos.DAO;
using ProyectoFinal_G8.Modelos.Entidades;
using ProyectoFinal_G8.Vistas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Controladores
{
    public class FacturaController
    {
        FacturaView vista;
        ClienteDAO userDAO = new ClienteDAO();
        Factura user = new Factura();
        String operacion = string.Empty;

        

    }
}
