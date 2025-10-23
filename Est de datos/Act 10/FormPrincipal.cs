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
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    centro.ImportaCsvSolicitudesEntrantes(fs);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null) fs.Close();
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

                nodo = nodo.Next;

            }
        }

        private void lsbVerSolicitudesImportadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicitud seleccionada = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;

            if (seleccionada != null)
            {
                lbSolicitudSeleccionada.Text= seleccionada.ToString();
            }


        }

        private void btnConfirmarAtencion_Click(object sender, EventArgs e)
        {
            Solicitud seleccionada = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;
            if (seleccionada != null)
            {
                centro.Atender(seleccionada);

                VerSolicitudesAAtender();
                VerSolicitudesPendientes();

                lsbVerSolicitudesImportadas.SelectedItem = null;
                lbSolicitudSeleccionada.Text = "Seleccione un registro";

            }

        }


        protected void VerSolicitudesAAtender()
        {
            lsbColaSolicitudesAAtender.Items.Clear();

            lsbColaSolicitudesAAtender.Items.AddRange(centro.VerDescripcionAtencion());
        }
    }
}
