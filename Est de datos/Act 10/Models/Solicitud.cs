using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_10.Models
{
    [Serializable]
    public class Solicitud : IExportable
    {
        public int Numero { get; set; }

        public string Descripcion { get; set; }

        public string Exportar()
        {
            return null; 
        }

        public void Importar(string linea)
        {
            string[] campos = linea.Split(';');
            Numero = Convert.ToInt32(campos[0]);
            Descripcion = campos[1];

            
        }

        //public Solicitud()
        //{

        //}

        //public Solicitud (int numero, string descripcion)
        //{
        //    this.Numero = numero;
        //    this.Descripcion = descripcion;
        //}



        public override string ToString()
        {
            return $"Solicitud Numero {Numero} Descripcion {Descripcion}";
        }
    }
}
