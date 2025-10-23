using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_10.Models
{
    [Serializable]
    public class CentroDeAtencion
    {
        LinkedList<Solicitud> solicitudesEntrantes = new LinkedList<Solicitud>();
        public void ImportaCsvSolicitudesEntrantes(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                Solicitud solicitud = new Solicitud();
                solicitud.Importar(linea);

                solicitudesEntrantes.AddLast(solicitud);
            }

            sr.Close();

        }

        public LinkedListNode<Solicitud> GetSOlicitudesPendientes()
        {
            return solicitudesEntrantes.First;
        }
    }
}
