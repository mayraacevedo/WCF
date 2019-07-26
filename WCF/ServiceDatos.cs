using CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    
    public class ServiceDatos : IServiceDatos
    {

        public Empleado GetEmpleadoByID(int Cedula)
        {
            CADEmpleado emple = CADEmpleado.GetEmpleadoByID2(Cedula);
            if (emple == null) return null;
            return ConvertTipo(emple);

        }

        private Empleado ConvertTipo(CADEmpleado emple)
        {
            Empleado emp = new Empleado();
            emp.ID = emple.ID;
            emp.nombre = emple.nombre;
            emp.cargo = emple.cargo;
            emp.Cedula = emple.Cedula;
            return emp;
        }

        public List<Empleado> GetEmpleadosByCargo(string IDCargo)
        {
            DS.tblEmpleadosDataTable table = CADEmpleado.GetEmpleadobyCargo(IDCargo);
            if (table.Rows.Count == 0) return null;
            List<Empleado> miempl = new List<Empleado>();
            foreach (DS.tblEmpleadosRow item in table.Rows)
            {
                Empleado obj = new Empleado();
                obj.ID = item.ID;
                obj.nombre = item.Nombre;
                obj.cargo = item.Cargo;
                obj.Cedula = item.Cedula;
                miempl.Add(obj);
            }
            return miempl;

            
        }
    }
}
