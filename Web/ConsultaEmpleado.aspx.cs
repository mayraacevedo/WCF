using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.ServiceReference1;

namespace Web
{
    public partial class ConsultaEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            ServiceDatosClient serv = new ServiceDatosClient();
            int Cedula=0;
            Int32.TryParse(txtCedula.Text,out Cedula);
            Empleado empleado = serv.GetEmpleadoByID(Cedula);
            if (empleado == null)
            {
 
            }
            lblNombre.Text = empleado.nombre;
            lblCargo.Text = empleado.cargo;

        }

        protected void btnDepartamento_Click(object sender, EventArgs e)
        {
            ServiceDatosClient serv = new ServiceDatosClient();
            Empleado[] empleado = serv.GetEmpleadosByCargo(txtDepartamento.Text);

            gvDatos.DataSource = empleado;
            gvDatos.DataBind();

        }
    }
}