using CAD.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class CADEmpleado
    {
       
        public int ID { get; set; }
        public int Cedula { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }

        private static tblEmpleadosTableAdapter adapter = new tblEmpleadosTableAdapter();
       
        public static DS.tblEmpleadosDataTable GetEmpleadoByID(int Vneg_Cedula)
        {
            return  adapter.GetEmpleadoByID(Vneg_Cedula);
        }

        public static CADEmpleado GetEmpleadoByID2(int vneg_Cedula)
        {
            CADEmpleado miEm = null;
            DS.tblEmpleadosDataTable Table = adapter.GetEmpleadoByID(vneg_Cedula);
            if (Table.Rows.Count == 0) return miEm;
            DS.tblEmpleadosRow Reg = (DS.tblEmpleadosRow)Table.Rows[0];
            miEm = new CADEmpleado();
            miEm.nombre = Reg.Nombre;
            miEm.cargo = Reg.Cargo;
            miEm.ID = Reg.ID;
            miEm.Cedula = Reg.Cedula;
            return miEm;

        }

        public static DS.tblEmpleadosDataTable GetEmpleadobyCargo(string Cargo)
        {
            return adapter.GetEmpleadosByCargo(Cargo);
        }
    }
}
