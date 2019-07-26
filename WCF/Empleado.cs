using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    [DataContract]
    public class Empleado
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int Cedula { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string cargo { get; set; }
    }
}
