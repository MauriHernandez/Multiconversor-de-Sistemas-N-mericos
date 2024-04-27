using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MulticonversorSistemasNumericos
{
       public class Service1 : IService1
    {

        public string ConvertirBase2(int numeroBase10)
        {
            string resultadoBase2=  null;
            resultadoBase2 = Convert.ToString(numeroBase10, 2);
            return resultadoBase2;

        }
        public string ConvertirBase8(int numeroBase10)
        {
            string resultadoBase8=null;
            resultadoBase8 = Convert.ToString(numeroBase10, 8);
            return resultadoBase8;
        }
        public string ConvertirBase16(int numeroBase10)
        {
            string resultadoBase16 = null;
            resultadoBase16 = Convert.ToString(numeroBase10, 16);
            return resultadoBase16;
        }


        public Conversiones ConvertirTodasLasBases(int numeroBase10)
        {
            string resultadoBase2 = null;
            resultadoBase2= Convert.ToString(numeroBase10, 2);
            string resultadoBase8 = null;
            resultadoBase8 = Convert.ToString(numeroBase10, 8);
            string resultadoBase16 = null;
            resultadoBase16 = Convert.ToString(numeroBase10, 16);

            Conversiones conversiones = new Conversiones();
            conversiones.ResultadoBase8 = resultadoBase8;
            conversiones.ResultadoBase2 = resultadoBase2;
            conversiones.ResultadoBase16 = resultadoBase16;
            return conversiones;
        }
    }
}
