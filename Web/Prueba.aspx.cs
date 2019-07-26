using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.ServiceReference1;

namespace Web
{
    public partial class Prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            ServiceDatosClient ser = new ServiceDatosClient();
            int cedula=0;
            Empleado Emp = ser.GetEmpleadoByID(cedula);

        }
    }
}