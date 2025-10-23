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
        Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
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

         
        public void Atender (Solicitud solicitud)
        {
            solicitudesEntrantes.Remove(solicitud);

            colaDeAtencion.Enqueue(solicitud);
        }
        public LinkedListNode<Solicitud> GetSOlicitudesPendientes()
        {
            return solicitudesEntrantes.First;
        }

        public string[] VerDescripcionAtencion()
        {
            string[] descripciones = new string[colaDeAtencion.Count()];

            int n = 0; 
            foreach (Solicitud solicitud in colaDeAtencion)
            {
                descripciones[n++] = solicitud.ToString();
            }
            return descripciones;
        }
    }
}
