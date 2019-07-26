using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
   
    [ServiceContract]
    public interface IServiceDatos
    {
        [OperationContract]
        Empleado GetEmpleadoByID(int Cedula);

        [OperationContract]
         List<Empleado> GetEmpleadosByCargo(string IDCargo);

       
    }

    
}
