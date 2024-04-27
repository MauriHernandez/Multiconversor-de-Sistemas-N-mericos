using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MulticonversorSistemasNumericos
{
    //contrato de servicio, siempre se ocupa
    [ServiceContract]
    public interface IService1
    {
        //contrato de operacion para conversor base 2
        [OperationContract]
        string ConvertirBase2(int numeroBase10);
        //contrato de operacion para conversor base 8
        [OperationContract]
        string ConvertirBase8(int numeroBase10);
        //contrato de operacion para conversor base 16
        [OperationContract]
        string ConvertirBase16(int numeroBase10);
        //contrato de operacion para conversor a todas las bases 2, 8, 16
        [OperationContract]
        Conversiones ConvertirTodasLasBases(int numeroBase10);


    }
   [DataContract]
    public class Conversiones
    {
        string resultadoBase2;
        string resultadoBase8;
        string resultadoBase16;

        [DataMember]
        public string ResultadoBase2
        {
            get { return resultadoBase2; }
            set { resultadoBase2 = value; }
        }
        [DataMember]
        public string ResultadoBase8
        {
            get { return resultadoBase8; }
            set { resultadoBase8 = value; }
        }
        [DataMember]
        public string ResultadoBase16
        {
            get { return resultadoBase16; }
            set { resultadoBase16 = value; }
        }
    }
}
