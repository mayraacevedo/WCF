using CAD.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class CADProducto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int numero { get; set; }
        public string departamento { get; set; }

        private static tblEmpleadosTableAdapter adapter= new tblEmpleadosTableAdapter();

        public static DS.tblEmpleadosDataTable GetempleadoBYID(int Cedula)
        {
            return adapter.GetEmpleadoByID(Cedula);
        }

        public static CADProducto GetempleadoByMucho(int Cedula)
        {
            CADProducto miem = null;
            DS.tblEmpleadosDataTable Table = adapter.GetEmpleadoByID(Cedula);
            if (Table.Rows.Count == 0) return null;

            DS.tblEmpleadosRow registro = (DS.tblEmpleadosRow)Table.Rows[0];

            miem = new CADProducto();
            miem.nombre = registro.Nombre;
            miem.departamento = registro.Cargo;
            return miem;

        }
       
    }
}
