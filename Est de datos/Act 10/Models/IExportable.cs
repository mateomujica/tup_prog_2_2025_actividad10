using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_10.Models
{
    public interface IExportable
    {
        void Importar(string linea);

        string Exportar();

    }
}
