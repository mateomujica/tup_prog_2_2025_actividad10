using Act_10.Models;

namespace Act_10
{
    public partial class FormPrincipal : Form
    {
        CentroDeAtencion centro = new CentroDeAtencion();
      
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnImportarSolicitudes_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;

                try
                {
                    fs=new FileStream(path,FileMode.Open, FileAccess.Read);
                    centro.ImportaCsvSolicitudesEntrantes(fs);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if  (fs != null) fs.Close();
                }

                VerSolicitudesPendientes();
            
            }
        }

        protected void VerSolicitudesPendientes()
        {
            lsbVerSolicitudesImportadas.Items.Clear();

            LinkedListNode<Solicitud> nodo = centro.GetSOlicitudesPendientes();

            while (nodo != null)
            {
                
                lsbVerSolicitudesImportadas.Items.Add(nodo.Value);

                nodo=nodo.Next;

            }
        }
    }
}
